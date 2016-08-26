using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoders
    {
        // 1- Define a delegate
        public delegate void VideoEncodeEventHandler(object source, EventArgs args);

        // 2- Define an event based on that delegate
        public event VideoEncodeEventHandler VideoEncoded;

        


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }


        // 3- Raise the event
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }

    }
}
