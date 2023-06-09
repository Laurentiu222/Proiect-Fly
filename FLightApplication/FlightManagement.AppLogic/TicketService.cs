﻿using FlightManagement.Abstractions.Repository;
using FlightManagement.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.AppLogic
{
    public class TicketService
    {
        private readonly IRepositoryWrapper repositoryWrapper;
        
        public TicketService(IRepositoryWrapper repositoryWrapper)
        {
            this.repositoryWrapper = repositoryWrapper;
        }

        public IQueryable<TIcket> GetAllTickets(TIcket ticket)
        {
           return repositoryWrapper.TicketRepository.GetAll();
        }

        public void CreateFromEntity(TIcket ticket)
        {
            repositoryWrapper.TicketRepository.Add(ticket);
        }

        public void UpdateFromEntity(TIcket ticket)
        {
            repositoryWrapper.TicketRepository.Update(ticket);
        }

        public void DeleteFromEntity(TIcket ticket)
        {
            repositoryWrapper.TicketRepository.Delete(ticket);
        }

        public void TicketForFlight(TIcket ticket)
        {
            repositoryWrapper.TicketRepository.TicketForFlight(ticket);
        }

        public async Task SaveAsync()
        {
            await repositoryWrapper.TicketRepository.SaveAsync();
        }
    } 
}
