namespace LSPLibrary
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        object Salary { get; set; }

        void CalculatePerHourRate(int rank);
    }
}