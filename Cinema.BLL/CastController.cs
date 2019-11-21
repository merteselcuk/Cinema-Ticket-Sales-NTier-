using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.DAL;
using Cinema.DAL.Abstract;
using Cinema.DAL.Abstract.IRepositoryBases;
using Cinema.DTO;
using Cinema.Entity.Concrete;
using Cinema.Enums;
using Framework.Core;
using Framework.Core.DAL;
using Newtonsoft.Json;

namespace Cinema.BLL
{
    public class CastController
    {
        IUnitOfWork _uow;
        IRepository<Cast> _cr;
        LogController _lc;

        public CastController()
        {
            _uow = Singleton.Uow;
            _cr = _uow.GetRepository<Cast>();
            _lc = new LogController();
        }

        public ServiceResult CastAdd(CastDTO dto)
        {
            Cast cast = new Cast()
            {
                Id = Guid.NewGuid(),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                IsActive = true,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = SessionHelper.CurrentUser.Id
            };

            ServiceResult result;
            _uow.BeginTran();
            try
            {
                cast = _uow.GetRepository<Cast>().Add(cast);

                if (cast != null)
                {
                    //loglama
                    _lc.AddLog<Cast>(cast, ProcessTypeEnum.Add,cast.Id);

                    _uow.Commit();
                    result = new ServiceResult("Oyuncu başarılı bir şekilde eklendi", ResultState.Success);

                }
                else
                {
                    result = new ServiceResult("Oyuncuyu eklerken bir hata oluştu", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                //Log hata.
                result = new ServiceResult("Hata - 404", ResultState.Error);
            }

            return result;
        }

        public ServiceResult CastUpdate(CastDTO dto)
        {
            ServiceResult result;
            _uow.BeginTran();
            var guncellenecekCast = _uow.GetRepository<Cast>().Get(dto.Id);

            try
            {
                guncellenecekCast = _uow.GetRepository<Cast>().Update(guncellenecekCast);

                if (guncellenecekCast != null)
                {
                    _lc.AddLog<Cast>(guncellenecekCast, ProcessTypeEnum.Update, guncellenecekCast.Id);
                    _uow.Commit();
                    result = new ServiceResult("Oyuncu bilgileri güncellendi.", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("Güncelleme esnasında bir hata oluştu.", ResultState.Warning);
                }
            }
            catch (Exception)
            {
                _uow.Rollback();
                result = new ServiceResult("Hata - 404", ResultState.Error);
            }

            return result;
        }

        public ServiceResult CastDelete(CastDTO dto)
        {
            ServiceResult result;
            _uow.BeginTran();
            var silinecekCast = _uow.GetRepository<Cast>().Get(dto.Id);
            silinecekCast.IsDeleted = true;

            try
            {
                silinecekCast = _uow.GetRepository<Cast>().Update(silinecekCast);

                if (silinecekCast != null)
                {
                    _lc.AddLog<Cast>(silinecekCast, ProcessTypeEnum.Delete, silinecekCast.Id);
                    _uow.Commit();
                    result = new ServiceResult("Oyuncu silindi", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("Oyuncu silinirken bir hata meydana geldi.", ResultState.Warning);
                }
            }
            catch (Exception)
            {
                _uow.Rollback();
                result = new ServiceResult("Hata - 404", ResultState.Error);
            }

            return result;
        }

        public List<CastDTO> GetAllCasts()
        {
            var CastList = _uow.GetRepository<Cast>().Get(c => c.IsDeleted == false);
            return CastToDto(CastList);
        }

        private void CastToDto(Cast cast, CastDTO dto)
        {
            dto.Id = cast.Id;
            dto.FirstName = cast.FirstName;
            dto.LastName = cast.LastName;
        }
        private List<CastDTO> CastToDto(IEnumerable<Cast> casts)
        {
            List<CastDTO> result = new List<CastDTO>();
            foreach (var cast in casts)
            {
                CastDTO dto = new CastDTO();
                CastToDto(cast, dto);
                result.Add(dto);
            }
            return result;
        }
    }
}
