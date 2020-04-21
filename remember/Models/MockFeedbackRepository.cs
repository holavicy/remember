using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remember.Models
{
    public class MockFeedbackRepository : IFeedbackRepository
    {
        private List<Feedback> _feedbacks;
        public MockFeedbackRepository() {
            if (_feedbacks == null) {
                InitializeFeedback();
            }
        }

        private void InitializeFeedback() {
            _feedbacks = new List<Feedback> {
            new Feedback{ Id = 1,Name="陈明姣", Email="819953059@qq.com",Message="味道不错"}
            };
        }
        public IEnumerable<Feedback> GetAllFeedbacks()
        {
            return _feedbacks;
        }

        public void AddFeedback(Feedback feedback) {
            _feedbacks.Add(feedback);
        }
    }
}
