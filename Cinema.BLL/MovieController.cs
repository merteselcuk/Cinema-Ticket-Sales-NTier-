using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.DAL;
using Cinema.DAL.Abstract;
using Cinema.DTO;
using Cinema.Entity.Concrete;
using Cinema.Enums;
using Framework.Core;

namespace Cinema.BLL
{
    public class MovieController
    {
        IUnitOfWork _uow;
        DirectorController _dc;
        LogController _lc;
        public MovieController()
        {
            _uow = Singleton.Uow;
            _dc = new DirectorController();
            _lc = new LogController();
        }

        public ServiceResult MovieAdd(MovieDTO dto)
        {
            ServiceResult serviceResult;
            _uow.BeginTran();
            try
            {
                Movie movie = new Movie()
                {
                    Id = Guid.NewGuid(),
                    MovieName = dto.MovieName,
                    MovieTypeNo = dto.MovieTypeNo,
                    MovieTime = dto.MovieTime,
                    Year = dto.Year,
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    TD = dto.TD,
                    UserId = SessionHelper.CurrentUser.Id,
                };
                foreach (var item in dto.Casts)
                {
                    Cast cast = _uow.GetRepository<Cast>().Get(item.Id);
                    movie.Casts.Add(cast);
                }
                foreach (var item in dto.Directors)
                {
                    Director director = _uow.GetRepository<Director>().Get(item.Id);
                    movie.Directors.Add(director);
                }
                var result = _uow.GetRepository<Movie>().Add(movie);
                if (result != null)
                {
                    _lc.AddLog<Movie>(movie, ProcessTypeEnum.Add, movie.Id);
                    _uow.Commit();
                    serviceResult = new ServiceResult("Film başarıyla eklendi.", ResultState.Success);
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

        public ServiceResult DeleteMovie(MovieDTO dto)
        {
            ServiceResult serviceResult;
            _uow.BeginTran();
            try
            {
                Movie movie = _uow.GetRepository<Movie>().Get(dto.Id);
                movie.IsDeleted = true;
                Movie deletedMovie = _uow.GetRepository<Movie>().Update(movie);
                if (deletedMovie != null)
                {
                    _lc.AddLog<Movie>(movie, ProcessTypeEnum.Delete, movie.Id);
                    _uow.Commit();
                    serviceResult = new ServiceResult("Film başarıyla silindi.", ResultState.Success);
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

        public List<MovieDTO> GetAllMovies()
        {
            ICollection<Movie> movies = _uow.GetRepository<Movie>().Get(m => m.IsDeleted == false && m.IsActive==true);
            return MovieToDto(movies);
        }

        public ServiceResult UpdateMovie(MovieDTO dto)
        {
            ServiceResult serviceResult;
            _uow.BeginTran();
            try
            {
                Movie movie = _uow.GetRepository<Movie>().Get(dto.Id);
                DtoToMovie(dto, movie);
                Movie UpdatedMovie = _uow.GetRepository<Movie>().Update(movie);
                if (UpdatedMovie != null)
                {
                    _lc.AddLog<Movie>(movie, ProcessTypeEnum.Update, movie.Id);
                    _uow.Commit();
                    serviceResult = new ServiceResult("Film başarıyla güncellendi.", ResultState.Success);
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
        private void DtoToMovie(MovieDTO dto, Movie movie)
        {
            movie.Id = dto.Id;
            movie.MovieName = dto.MovieName;
            movie.MovieTime = dto.MovieTime;
            movie.MovieTypeNo = dto.MovieTypeNo;
            movie.TD = dto.TD;
            movie.Year = dto.Year;
            movie.IsActive = dto.IsActive;
            movie.Directors.Clear();
            movie.Casts.Clear();
            foreach (var item in dto.Directors)
            {
                Director director = _uow.GetRepository<Director>().Get(item.Id);
                movie.Directors.Add(director);

            }
            foreach (var item in dto.Casts)
            {
                Cast cast = _uow.GetRepository<Cast>().Get(item.Id);
                movie.Casts.Add(cast);
            }

        }
        private void MovieToDto(Movie movie, MovieDTO dto)
        {
            dto.Id = movie.Id;
            dto.MovieName = movie.MovieName;
            dto.MovieTime = movie.MovieTime;
            dto.MovieTypeNo = movie.MovieTypeNo;
            dto.TD = movie.TD;
            dto.Year = movie.Year;
            dto.IsActive = movie.IsActive;
            foreach (var item in movie.Directors)
            {
                DirectorDTO dtoDirector = new DirectorDTO()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,

                };
                dto.Directors.Add(dtoDirector);
            }
            foreach (var item in movie.Casts)
            {
                CastDTO dtoCast = new CastDTO()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,

                };
                dto.Casts.Add(dtoCast);
            }

        }
        private List<MovieDTO> MovieToDto(IEnumerable<Movie> movies)
        {
            List<MovieDTO> result = new List<MovieDTO>();
            foreach (var movie in movies)
            {
                MovieDTO dto = new MovieDTO();
                MovieToDto(movie, dto);
                result.Add(dto);
            }
            return result;
        }


    }
}
