namespace Blazor
{
    public class SharedStateService
    {
        public Client Account { get; set; } = new Client() {Username="Guest" };

        public void UpdateSharedVariable(Client value)
        {
            Account = value;
        }
    }
}
