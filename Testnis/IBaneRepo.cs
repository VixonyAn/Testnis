using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testnis
{
    public interface IBaneRepo
    {
        List<Bane> GetAllBane();
        Bane GetBaneById(int baneId);
        void CreateBane(Bane bane);
        void UpdateBane(Bane bane, int baneId);
        void DeleteBane(int baneId);
    }
}
