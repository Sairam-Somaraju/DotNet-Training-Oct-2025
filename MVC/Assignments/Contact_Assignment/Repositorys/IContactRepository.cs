using Contact_Prj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Prj.Repositorys
{
    public interface IContactRepository 
    {
        Task<List<Contact>> GetAllAsync(); //Get all Contact Details
        Task CreateAsync(Contact contact);
        Task DeleteAsync(long Id);
       
    }
}
