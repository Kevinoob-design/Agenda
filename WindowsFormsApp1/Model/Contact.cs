namespace Model
{
    /// <summary>
    /// Class contact with information releated to certain contact
    /// </summary>
    public struct Contact
    {
        /// <summary>
        /// Basic information that belongs to a contact.
        /// </summary>
        /// 
        //public int contactID { get { return contactID; } set { contactID = 11; } }
        public string contactID { get; set; }

        public string name { get; set; }
        public string lastName { get; set; }
        public string anotations { get; set; }

        public string cellPhone { get; set; }
        public string workPhone { get; set; }
        public string homePhone { get; set; }

        public string email { get; set; }
        public string workEmail { get; set; }



        public string street { get; set; }
        public string unit { get; set; }
        public string sector { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string zip { get; set; }
    }
}
