using System.Data;
using TomorrowSoft.DAL;

namespace BLL
{
    public class MessageIndexService
    {
        private MessageIndexRepository _repository = new MessageIndexRepository();

        public bool Add(string mesIndex)
        {
           return _repository.Add(mesIndex);
        }

        public DataTable GetAll()
        {
            return _repository.GetAll();
        }

        public void Delete()
        {
            _repository.Delete();
        }
    }
}