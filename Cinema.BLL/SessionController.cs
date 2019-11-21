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
    public class SessionController
    {
        IUnitOfWork _uow;
        IRepository<Session> _sr;
        LogController _lc;
        public SessionController()
        {
            _uow = Singleton.Uow;
            _sr = _uow.GetRepository<Session>();
            _lc = new LogController();
        }

        public ServiceResult SessionAdd(SessionDTO dto)
        {
            
            Session session = new Session()
            {
                MovieId=dto.MovieId,
                SeanceId=dto.SeanceId,
                TheaterId=dto.TheaterId,
                ShowDate=dto.ShowDate,
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                UserId = SessionHelper.CurrentUser.Id,
                Id = Guid.NewGuid()
            };
            ServiceResult result;
            _uow.BeginTran();
            try
            {
                var SessionIsAdded = _uow.GetRepository<Session>().GetSpesific(s => s.MovieId == dto.MovieId && s.SeanceId == dto.SeanceId && s.TheaterId == dto.TheaterId && s.ShowDate == dto.ShowDate && s.IsDeleted == false && s.IsActive == true);
                if (SessionIsAdded == null) 
                { 
                    Session islemYapildiMi = _uow.GetRepository<Session>().Add(session);
                    if (islemYapildiMi != null)
                    {
                        _lc.AddLog<Session>(session, ProcessTypeEnum.Add, session.Id);
                        _uow.Commit();
                        result = new ServiceResult("İşlem başarılı", ResultState.Success);
                    }
                    else
                    {
                        result = new ServiceResult("Yapılacak bir işlem kaydına rastlanmadı.",     ResultState.Warning);
                    }
                }
                else
                {
                    result = new ServiceResult("Eklemek istediğiniz kayıt Oturum listesinde mevcut! ",ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                result = new ServiceResult("Hata", ResultState.Error);
            }
            return result;
        }
        public List<SessionDTO> GetAllSession()
        {
            IEnumerable<Session> sessions = _uow.GetRepository<Session>().Get(m => m.IsActive == true);
            return SessionToDto(sessions);
        }
        public ServiceResult SessionDelete(SessionDTO dto)
        {
            var session = _uow.GetRepository<Session>().Get(dto.Id);
            session.IsDeleted = true;
            session.IsActive = false;
            session.UserId = Guid.NewGuid();

            ServiceResult result;
            _uow.BeginTran();
            try
            {
                Session islemYapildiMi = _uow.GetRepository<Session>().Update(session);
                if (islemYapildiMi != null)
                {
                    _lc.AddLog<Session>(session, ProcessTypeEnum.Delete, session.Id);
                    _uow.Commit();
                    result = new ServiceResult("İşlem başarılı", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("Yapılacak bir işlem kaydına rastlanmadı.", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                result = new ServiceResult("Hata", ResultState.Error);
            }
            return result;
        }
        public ServiceResult SessionUpdate(SessionDTO dto)
        {

            var session = _uow.GetRepository<Session>().Get(dto.Id);
            DtoToSession(dto, session);
            ServiceResult result;
            _uow.BeginTran();
            try
            {
                var sessionIsUpdated = _uow.GetRepository<Session>().GetSpesific(s => s.MovieId == dto.MovieId && s.SeanceId == dto.SeanceId && s.TheaterId == dto.TheaterId && s.ShowDate == dto.ShowDate && s.IsDeleted == false && s.IsActive == dto.IsActive);
                if (sessionIsUpdated == null) { 
                Session islemYapildiMi = _uow.GetRepository<Session>().Update(session);
                if (islemYapildiMi != null)
                {
                        _lc.AddLog<Session>(session, ProcessTypeEnum.Update, session.Id);
                        _uow.Commit();
                        result = new ServiceResult("İşlem Başarılı", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("Yapılacak bir işlem kaydına rastlanamadı", ResultState.Warning);
                }
                }
                else
                {
                    result = new ServiceResult("Eklemek istediğiniz kayıt Oturum listesinde mevcut!", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                result = new ServiceResult("Hata", ResultState.Error);
            }
            return result;
        }
        private void SessionToDto(Session session, SessionDTO dto)
        {
            dto.Id = session.Id;
            dto.MovieId = session.MovieId;
            dto.SeanceId = session.SeanceId;
            dto.TheaterId = session.TheaterId;
            dto.ShowDate = session.ShowDate;
            dto.MovieName = session.Movie.MovieName;
            dto.TheaterName = session.Theater.TheaterName;
            dto.StartTime = session.Seance.StartTime;
            dto.FinishTime = session.Seance.FinishTime;
            dto.IsActive = session.IsActive;
        }
        private List<SessionDTO> SessionToDto(IEnumerable<Session> sessions)
        {
            List<SessionDTO> result = new List<SessionDTO>();

            foreach (var session in sessions)
            {
                SessionDTO dto = new SessionDTO();
                SessionToDto(session, dto);
                result.Add(dto);
            }
            return result;
        }
        private void DtoToSession(SessionDTO dto,Session session)
        {
            session.Id = dto.Id;
            session.MovieId = dto.MovieId;
            session.SeanceId = dto.SeanceId;
            session.TheaterId = dto.TheaterId;
            session.ShowDate = dto.ShowDate;
            session.IsActive = dto.IsActive;
        }
        

    }
}
