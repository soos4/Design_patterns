using System;
namespace Observer
{
    public interface Subscriber
    {
        public void Update(Stock stock);
    }
}
