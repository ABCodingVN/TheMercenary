
using BackendTiki.Models;
using BackendTiki.Interface;
using BackendTiki.Access;
namespace BackendTiki.Repository
{
    public class ProvinceRepository : IProvinceRepository, IDisposable

    {
        private Context context;

        public ProvinceRepository(Context context)
        {
            this.context = context;
        }

        public List<Province> GetProvices()
        {
            return context.Province.ToList();
        }

        public Province GetProviceByID(string ProviceId)
        {
            Province Province = context.Province.SingleOrDefault(e=>e.ProvinceId==ProviceId);
            if (Province == null)
                return null;
            return Province;
        }

        public void InsertProvice(Province Provice)
        {
            context.Province.Add(Provice);
            Save();
        }
 

 
 
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

     
    }
}
