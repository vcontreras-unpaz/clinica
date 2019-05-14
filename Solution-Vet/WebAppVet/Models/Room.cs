using ClientPatientManagement.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ClientPatientManagement.Core.Model
{
    public partial class Room : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

    }
    
}