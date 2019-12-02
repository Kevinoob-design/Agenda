namespace Model
{
    public struct Event
    {
        public string eventID   { get; set; }
        public string tittle    { get; set; }   
        public string location  { get; set; }
        public string startDate    { get; set; }
        public string endDate      { get; set; }
        public string frequency { get; set; }
        public string priority { get; set; }
        public string invites   { get; set; }
        public string details     { get; set; }
    }
}
