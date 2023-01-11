namespace InsertForm.Services
{
    public interface IAddFormService
    {
        Task<UserForm> AddNewForm(UserForm form);
    }
}
