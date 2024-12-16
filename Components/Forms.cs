using System.Runtime.Serialization;

namespace FEH.Components
{
    public class Forms
    {
        public int ID { set;  get; }
        public string? FirstName { set; get; }
        public string? LastName { set; get; }
        /*public decimal MonthlyIncome { set; get; }
        public int HouseholdPets {  set; get; }
        public int HouseholdHumans {   set; get;  }
        public bool Felon {  set; get; }*/
        public string? Email { set; get; }
        [IgnoreDataMember]
        public string? DogName { set; get; }
        [IgnoreDataMember]
        public string? Status { set; get; }
        [IgnoreDataMember]
        public DateTime TimeSubmitted { set; get; }
        public string? Address { set; get; }
        [IgnoreDataMember]
        public int DogID { set; get; }
        /*public Forms ()
        {

        }
        
        public Forms(int ID, string DogName, string Status,  DateTime TimeSubmitted, int DogID)
        {
            this.ID = ID;
            this.Status = Status;
            this.TimeSubmitted = TimeSubmitted;
            this.DogID = DogID;
        }
        */
    }
}
