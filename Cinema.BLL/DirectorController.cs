using Cinema.DAL;
using Cinema.DAL.Abstract;
using Cinema.DAL.Abstract.IRepositoryBases;
using Cinema.DTO;
using Cinema.Entity.Concrete;
using Cinema.Enums;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BLL
{
    public class DirectorController
    {
        IUnitOfWork _uow;
        IRepository<Director> _pr;
        LogController _lc;

        public DirectorController()
        {
            _uow = Singleton.Uow;
            _pr = _uow.GetRepository<Director>();
            _lc = new LogController();
        }

        public ServiceResult DirectorAdd(DirectorDTO dto)
        {
            Director director = new Director()
            {
                Id = Guid.NewGuid(),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                IsActive = true,
                CreatedDate = DateTime.Now,
                IsDeleted =false,
                UserId = SessionHelper.CurrentUser.Id
            };
            ServiceResult result;
            _uow.BeginTran();
            try
            {
                var directorIsAdded = _uow.GetRepository<Director>().GetSpesific(d => d.FirstName == dto.FirstName
                && d.LastName == dto.LastName
                && d.IsDeleted == false
                && d.IsActive == true);

                if (directorIsAdded == null)
                {
                    Director islemYapildimi = _uow.GetRepository<Director>().Add(director);
                    if (islemYapildimi != null)
                    {
                        _lc.AddLog<Director>(director, ProcessTypeEnum.Add, director.Id);
                        _uow.Commit();
                        result = new ServiceResult("İşlem başarılı", ResultState.Success);
                    }
                    else
                    {
                        result = new ServiceResult("Yapılacak bir işlem kaydına rastlanmadı.", ResultState.Warning);
                    }
                }
                else
                {
                    result = new ServiceResult("Eklemek istediğiniz kayıt Seans listesinde mevcut!", ResultState.Error);
                }
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                result = new ServiceResult("Hata", ResultState.Error);
            }
            return result;
            
        }
        public List<DirectorDTO> SelectAllDirectors()
        {
            IEnumerable<Director> directors = _uow.GetRepository<Director>().Get(d => d.IsDeleted == false);
            return DirectorToDto(directors);
        }

        private void DtoToDirector(DirectorDTO dto, Director director)
        {
            director.Id = dto.Id;
            director.FirstName = dto.FirstName;
            director.LastName = dto.LastName;
        }

        private void DirectorToDto(Director director, DirectorDTO dto)
        {
            dto.Id = director.Id;
            dto.FirstName = director.FirstName;
            dto.LastName = director.LastName;
        }

        private List<DirectorDTO> DirectorToDto(IEnumerable<Director> directors)
        {
            List<DirectorDTO> result = new List<DirectorDTO>();

            foreach (var product in directors)
            {
                DirectorDTO dto = new DirectorDTO();
                DirectorToDto(product, dto);
                result.Add(dto);
            }
            return result;
        }

        public ServiceResult DirectorUpdate(DirectorDTO dto)
        {
            var director = _uow.GetRepository<Director>().Get(dto.Id);
            DtoToDirector(dto, director);
            ServiceResult result;
            _uow.BeginTran();
            try
            {
                var directorUpdated = _uow.GetRepository<Director>().GetSpesific(d => d.FirstName == dto.FirstName && d.LastName == dto.LastName && d.IsDeleted == false);
                if (directorUpdated == null)
                {
                    Director islemYapildiMi = _uow.GetRepository<Director>().Update(director);
                    if (islemYapildiMi != null)
                    {
                        _lc.AddLog<Director>(director, ProcessTypeEnum.Update, director.Id);
                        _uow.Commit();
                        result = new ServiceResult("İşlem Başarılıdır.", ResultState.Success);
                    }
                    else
                    {
                        result = new ServiceResult("Yapılacak bir işlem kaydına rastlanamadı", ResultState.Warning);
                    }
                }
                else
                {
                    result = new ServiceResult("Eklemek istediğiniz kayıt yönetmen listesinde mevcut!", ResultState.Error);
                }
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                result = new ServiceResult("Hata", ResultState.Error);
            }
            return result;
        }

        public ServiceResult DirectorDelete(DirectorDTO dto)
        {
            var director = _uow.GetRepository<Director>().Get(dto.Id);
            director.IsDeleted = true;
            director.UserId = SessionHelper.CurrentUser.Id;
            ServiceResult result;
            _uow.BeginTran();
            try
            {
                Director islemYapildiMi = _uow.GetRepository<Director>().Update(director);
                if (islemYapildiMi != null)
                {
                    _lc.AddLog<Director>(director, ProcessTypeEnum.Delete, director.Id);
                    _uow.Commit();
                    result = new ServiceResult("İşlem Başarılıdır.", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("Yapılacak bir işlem kaydına rastlanamadı", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                result = new ServiceResult("Hata", ResultState.Error);
            }
            return result;
        }
    }
}
