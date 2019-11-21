using Cinema.DAL;
using Cinema.DAL.Abstract;
using Cinema.Entity.Concrete;
using Cinema.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BLL
{
    public class LogController
    {
        IUnitOfWork _uow;
        public LogController()
        {
            _uow = Singleton.Uow;
        }
        public Log AddLog<TEntity>(TEntity entity, ProcessTypeEnum ProcessType,Guid Id)
            where TEntity:new()
        {
            string json = JsonConvert.SerializeObject(CloneWithoutClassProperty(entity));
            Log log = new Log();
            log.Table = entity.GetType().Name.Split('_')[0];
            log.Data = json;
            log.DateTime = DateTime.Now;
            log.Id = Guid.NewGuid();
            log.ProcessType = ProcessType;
            log.RoleId = _uow.GetRepository<User>().Get(SessionHelper.CurrentUser.Id).Roles.FirstOrDefault().Id;
            log.RowGuid = Id;
            log.UserId = SessionHelper.CurrentUser.Id;

            return _uow.GetRepository<Log>().Add(log);
        }

        private T CloneWithoutClassProperty<T>(T entity)
            where T:new()
        {
            T t = new T();
            var propertyInfos = entity.GetType().GetProperties();
            foreach (var propertyInfo in propertyInfos)
            {
                if(propertyInfo.PropertyType.IsValueType||propertyInfo.PropertyType==typeof(string))
                {
                    var value = propertyInfo.GetValue(entity);
                    propertyInfo.SetValue(t, value);
                }
            }
            return t;
        }
    }
}
