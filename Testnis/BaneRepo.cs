using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Testnis
{
    public class BaneRepo : IBaneRepo
    {
        #region Instance Fields
        private Dictionary<int, Bane> _baner;
        #endregion

        #region Constructors
        public BaneRepo()
        {
            _baner = new Dictionary<int, Bane>();
        }
        #endregion

        #region Methods
        public List<Bane> GetAllBane()
        {
            return _baner.Values.ToList();
        }
        public Bane GetBaneById(int baneId)
        {
            if (baneId != null && _baner.ContainsKey(baneId))
            {
                return _baner[baneId];
            }
            return null;
        }

        public void CreateBane(Bane bane)
        {
            if (!_baner.ContainsKey(bane.BaneID)) // hvis key er ledigt
            {
                _baner.Add(bane.BaneID, bane);
            }
            else
            {
                throw new Exception($"Bane ID '{bane.BaneID}' findes allerede\n");
            }
        }
        public void UpdateBane(Bane bane, int baneId)
        {
            if (_baner.ContainsKey(baneId)) // hvis key ikke er ledigt
            {
                throw new Exception($"Bane ID '{bane.BaneID}' findes allerede\n");
            }
            if (_baner[baneId].BaneID != baneId)
            {
                throw new Exception($"Violation of primary key, this value may not be changed");
            }
            _baner[baneId] = bane;
        }

        public void DeleteBane(int baneId)
        {
            _baner.Remove(baneId);
        }
        #endregion
    }
}
