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

namespace Cinema.BLL
{
    public class UserController
    {
        IUnitOfWork _uow;
        LogController _lc;
    
        public UserController()
        {
            _uow = Singleton.Uow;
            _lc = new LogController();
          
        }
        public UserDTO SearchUser(UserDTO dto)
        {
            var user = _uow.GetRepository<User>().GetSpesific(u => u.UserName == dto.UserName && u.Password == dto.Password && u.IsDeleted==false && u.IsActive==true);
            if (user!=null)
            {
                SessionHelper.CurrentUser = dto;
                dto.Id = user.Id;
                dto.UserName = user.UserName;
                dto.Password = user.Password;
                return dto;
            }
            
            return null;
        }

        public List<UserDTO> GetAllUsers()
        {
            ICollection<User> users = _uow.GetRepository<User>().Get(u => u.IsDeleted == false);
            return UserToDto(users);
        }

        public ServiceResult UserAdd(UserDTO dto, RoleDTO roleDTO)
        {
            ServiceResult serviceResult;
            _uow.BeginTran();
            try
            {
                #region Validation
                User validation = _uow.GetRepository<User>().GetSpesific(u => u.UserName == dto.UserName && u.IsDeleted == false);
                if (validation != null)
                {
                    serviceResult = new ServiceResult("Aynı isimde bir kişi eklenemez.", ResultState.Warning);
                    return serviceResult;
                }
                #endregion
                User user = new User();
                user.Id = Guid.NewGuid();
                user.UserName = dto.UserName;
                user.Password = dto.Password;
                user.CreatedDate = DateTime.Now;
                user.IsActive = true;
                user.UserId = SessionHelper.CurrentUser.Id;
                Role role = _uow.GetRepository<Role>().Get(roleDTO.Id);
                user.Roles.Add(role);
                User result = _uow.GetRepository<User>().Add(user);
                if (result != null)
                {
                    _lc.AddLog<User>(user, ProcessTypeEnum.Add, user.Id);
                    _uow.Commit();
                    serviceResult = new ServiceResult("Yeni kişi eklendi.", ResultState.Success);
                }
                else
                {
                    serviceResult = new ServiceResult("Yapılacak bir işlem kaydına rastlanamadı.", ResultState.Warning);
                }
            }
            catch(Exception ex)
            {
                _uow.Rollback();
                serviceResult = new ServiceResult("Hata..", ResultState.Error);
            }
            return serviceResult;
            
        }

        public ServiceResult UpdatedUser(UserDTO dto)
        {
            ServiceResult serviceResult;
            _uow.BeginTran();
            try
            {
                var user = _uow.GetRepository<User>().Get(dto.Id);
                DtoToUser(dto, user);
                User UpdatedUser = _uow.GetRepository<User>().Update(user);
                if (UpdatedUser != null)
                {
                    _lc.AddLog<User>(user, ProcessTypeEnum.Update, user.Id);
                    _uow.Commit();
                    serviceResult = new ServiceResult("Kullanıcı başarıyla güncellendi.", ResultState.Success);
                }
                else
                {
                    serviceResult = new ServiceResult("Yapılacak bir işlem kaydına rastlanamadı", ResultState.Warning);
                }
            }
            catch(Exception ex)
            {
                _uow.Rollback();
                serviceResult= new ServiceResult("Hata..", ResultState.Error);
            }
            return serviceResult;
        }

        public ServiceResult DeleteUser(UserDTO dto)
        {
            ServiceResult serviceResult;
            _uow.BeginTran();
            try
            {
                var user = _uow.GetRepository<User>().Get(dto.Id);
                DtoToUser(dto, user);
                user.IsDeleted = true;
                User DeletedUser = _uow.GetRepository<User>().Update(user);
                if (DeletedUser != null)
                {
                    _lc.AddLog<User>(user, ProcessTypeEnum.Delete, user.Id);
                    _uow.Commit();
                    serviceResult = new ServiceResult("Kullanıcı başarıyla silindi.", ResultState.Success);
                }
                else
                {
                    serviceResult = new ServiceResult("Yapılacak bir işlem kaydına rastlanamadı", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                serviceResult = new ServiceResult("Hata..", ResultState.Error);
            }
            return serviceResult;
        }

        public ServiceResult UpdatePassword(UserDTO currentUser)
        {
            ServiceResult serviceResult;
            _uow.BeginTran();
            try
            {
                var user = _uow.GetRepository<User>().Get(currentUser.Id);
                DtoToUser(currentUser, user);
                user.UpdatedDate = DateTime.Now;
                user.CreatedDate = DateTime.Now;
                user.UserId = currentUser.Id;
                User UpdatedUser = _uow.GetRepository<User>().Update(user);
                if (UpdatedUser != null)
                {
                    _lc.AddLog<User>(user, ProcessTypeEnum.Update, user.Id);
                    _uow.Commit();
                    serviceResult = new ServiceResult("Şifre başarıyla güncellendi.", ResultState.Success);
                }
                else
                {
                    serviceResult = new ServiceResult("Yapılacak bir işlem kaydına rastlanamadı.", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                serviceResult = new ServiceResult("Hata..", ResultState.Error);
            }
            return serviceResult;
        }

        public List<RoleDTO> GetAllRoles()
        {
            ICollection<Role> roles = _uow.GetRepository<Role>().Get(r => r.IsDeleted == false);
            return RoleToDto(roles);
        }

        private void DtoToUser(UserDTO dto, User user)
        {
            user.Id = dto.Id;
            user.UserName = dto.UserName;
            user.Password = dto.Password;
            user.IsActive = dto.IsActive;

        }
        private void RoleToDto(Role role, RoleDTO dto)
        {
            dto.Id = role.Id;
            dto.RoleName = role.RoleName;

        }
        private List<RoleDTO> RoleToDto(IEnumerable<Role> roles)
        {
            List<RoleDTO> result = new List<RoleDTO>();
            foreach (var role in roles)
            {
                RoleDTO dto = new RoleDTO();
                RoleToDto(role, dto);
                result.Add(dto);
            }
            return result;
        }

        private void UserToDto(User user, UserDTO dto)
        {
            dto.Id = user.Id;
            dto.UserName = user.UserName;
            dto.Password = user.Password;
            dto.IsActive = user.IsActive;
            Role role = user.Roles.SingleOrDefault();
            RoleDTO roleDto = new RoleDTO();
            RoleToDto(role, roleDto);
            dto.Roles.Add(roleDto);
            
            
        }
        private List<UserDTO> UserToDto(IEnumerable<User> users)
        {
            List<UserDTO> result = new List<UserDTO>();
            foreach (var user in users)
            {
                UserDTO dto = new UserDTO();
                UserToDto(user, dto);
                result.Add(dto);
            }
            return result;
        }

    }
}
