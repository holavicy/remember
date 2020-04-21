using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remember.Models
{
    public class MockNoodleRepository : INoodleRepository
    {
        private List<Noodle> _noodles;

        public MockNoodleRepository() {
            if (_noodles == null) {
                InitializeNoodle();
            }
        }

        private void InitializeNoodle() {
            _noodles = new List<Noodle>
            {
                new Noodle { Id = 1, Name = "牛肉拉面", Price = 12, ShortDescription="牛肉很多", LongDescription="牛肉真的很多", ImageURL=""},
                new Noodle { Id = 2, Name = "西红柿鸡蛋拉面", Price = 10, ShortDescription = "西红柿很多", LongDescription = "西红柿鸡蛋很多", ImageURL = "" }
            };
        }
        public IEnumerable<Noodle> GetAllNoodles()
        {
            return _noodles;
        }

        public Noodle GetNoodleById(int id)
        {
            return _noodles.FirstOrDefault(n => n.Id == id);
        }
    }
}
