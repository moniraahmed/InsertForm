using InsertForm.Data;
using System.Net.Http.Headers;

namespace InsertForm.Services
{
    public class AddFormService: IAddFormService
    {
        private readonly DataContext _dataContext;
        public AddFormService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<UserForm> AddNewForm(UserForm _form)
        {
            try
            {
                if(_form.File?.Length > 0)
                {
                    var folderName = Path.Combine("Resources");
                    var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                    var fileName = ContentDispositionHeaderValue.Parse(_form.File.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                }
                _dataContext.UserForm.Add(_form);
                await _dataContext.SaveChangesAsync();
                return _form;
            }
            catch (Exception)
            {
                throw;
            }
            
           
        }
    }
}
