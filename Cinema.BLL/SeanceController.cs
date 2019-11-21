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
    public class SeanceController
    {
        IUnitOfWork _uow;
        IRepository<Movie> _mr;
        LogController _lc;
        public SeanceController()
        {
            _uow = Singleton.Uow;
            _mr = _uow.GetRepository<Movie>();
            _lc = new LogController();
        }

        public List<SeanceDTO> GetAllSeance()
        {
            ICollection<Seance> seances = _uow.GetRepository<Seance>().Get(s => s.IsDeleted == false);
            return SeanceToDto(seances);
        }

        public ServiceResult SeanceAdd(SeanceDTO dto)
        {

            Seance seance = new Seance()
            {
                FinishTime = dto.FinishTime,
                StartTime = dto.StartTime,
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                UserId=SessionHelper.CurrentUser.Id,
                Id = Guid.NewGuid()
            };
            ServiceResult result;
            _uow.BeginTran();
            try
            {
                var seanceIsAdded = _uow.GetRepository<Seance>().GetSpesific(s => s.StartTime == dto.StartTime && s.FinishTime == dto.FinishTime && s.IsDeleted==false);
                if (seanceIsAdded == null)
                {
                    Seance islemYapildimi = _uow.GetRepository<Seance>().Add(seance);
                    if (islemYapildimi != null)
                    {
                        _lc.AddLog<Seance>(seance, ProcessTypeEnum.Add, seance.Id);
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
                    result = new ServiceResult("Eklemek istediğiniz kayıt Seans listesinde mevcut!",ResultState.Error);
                }
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                result = new ServiceResult("Hata", ResultState.Error);
            }
            return result;
        }
        public ServiceResult SeanceDelete(SeanceDTO dto)
        {
            var seance = _uow.GetRepository<Seance>().Get(dto.Id);
            seance.IsDeleted = true;
            seance.UserId = SessionHelper.CurrentUser.Id;
            ServiceResult result;
            _uow.BeginTran();
            try
            {
                Seance islemYapildiMi = _uow.GetRepository<Seance>().Update(seance);
                if (islemYapildiMi!=null)
                {
                    _lc.AddLog<Seance>(seance, ProcessTypeEnum.Delete, seance.Id);
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
        public ServiceResult SeanceUpdate(SeanceDTO dto)
        {
            var seance = _uow.GetRepository<Seance>().Get(dto.Id);
            DtotoSeance(dto, seance);
            ServiceResult result;
            _uow.BeginTran();
            try
            {
                var seanceUpdated = _uow.GetRepository<Seance>().GetSpesific(s => s.StartTime == dto.StartTime && s.FinishTime == dto.FinishTime && s.IsDeleted == false);
                if (seanceUpdated==null)
                {
                   Seance islemYapildiMi = _uow.GetRepository<Seance>().Update(seance);
                   if (islemYapildiMi != null)
                   {
                        _lc.AddLog<Seance>(seance, ProcessTypeEnum.Update, seance.Id);
                        _uow.Commit();
                       result = new ServiceResult("İşlem Başarılıdır.", ResultState.Success);
                   }
                   else
                   {
                       result = new ServiceResult("Yapılacak bir işlem kaydına rastlanamadı",    ResultState.Warning);
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
        private void DtotoSeance(SeanceDTO dto,Seance seance)
        {
            seance.Id = dto.Id;
            seance.StartTime = dto.StartTime;
            seance.FinishTime = dto.FinishTime;
        }
        private void SeanceToDto(Seance seance, SeanceDTO dto)
        {
            dto.Id = seance.Id;
            dto.StartTime = seance.StartTime;
            dto.FinishTime = seance.FinishTime;
            
        }
        private List<SeanceDTO> SeanceToDto(IEnumerable<Seance> seances)
        {
            List<SeanceDTO> result = new List<SeanceDTO>();

            foreach (var seance in seances)
            {
                SeanceDTO dto = new SeanceDTO();
                SeanceToDto(seance,dto);
                result.Add(dto);
            }
            return result;
        }
    }
}
