namespace FEH.Components.Pages.MessagingPages
{
    public class Messaging
    {
        public string currentName = string.Empty;
        public string currentMessage = string.Empty;
        public string messages = string.Empty;

        public event Action? OnMessagesUpdated;

        public void AddMessage(string currentName, string currentMessage)
        {
            if (string.IsNullOrWhiteSpace(currentName))
            {
                currentName = "Anonymous";
            }
            if (currentName.Equals("(Admin) "))
            {
                currentName = "(Admin) Anonymous";
            }
            messages += currentName + ": " + currentMessage + "\n";
            currentMessage = string.Empty;
            currentName = string.Empty;
            OnMessagesUpdated?.Invoke();
        }
    }
}
