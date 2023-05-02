using FlightManagement.Abstractions.Repository;
using FlightManagement.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.AppLogic
{
    public class SeatService
    {
        private readonly IRepositoryWrapper repositoryWrapper;
        
        public SeatService(IRepositoryWrapper repositoryWrapper)
        {
            this.repositoryWrapper = repositoryWrapper;
        }

        public IQueryable<Seat> GetAllSeats()
        {
            return repositoryWrapper.SeatRepository.GetAll();
        }
        public void CreateFromEntity(Seat seat)
        {
            repositoryWrapper.SeatRepository.Add(seat);
        }

        public void UpdateFromEntity(Seat seat) 
        {
            repositoryWrapper.SeatRepository.Update(seat);
        }

        public void DeleteFromEntity(Seat seat) 
        {
            repositoryWrapper.SeatRepository.Delete(seat);
        }

        public void SeatForFlight(Seat seat)
        {
            repositoryWrapper.SeatRepository.SeatForFlight(seat);
        }

        public async Task SaveAsync()
        {
            await repositoryWrapper.SeatRepository.SaveAsync();
        }
    }
}
