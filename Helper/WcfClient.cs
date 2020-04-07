

using System;
using System.ServiceModel;

namespace Helper
{
    public class WcfClient<T1>
    {
        private static T1 _channelS = default(T1);

        public static T1 Channel(string endpoint)
        {
            if (_channelS != null) return _channelS;

            BasicHttpBinding basicHttpBinding = new BasicHttpBinding()
            {
                MaxReceivedMessageSize = long.MaxValue,
                MaxBufferSize = int.MaxValue,
                MaxBufferPoolSize = long.MaxValue,
                ReceiveTimeout = new TimeSpan(int.MaxValue),
                SendTimeout = TimeSpan.MaxValue,
                TransferMode = TransferMode.Streamed
            };

            EndpointAddress endpointAddress = new EndpointAddress(endpoint);
            ChannelFactory<T1> channelFactory = new ChannelFactory<T1>(basicHttpBinding,endpointAddress);

            T1 channel = channelFactory.CreateChannel();
            _channelS = channel;
            return channel;
        }
    }
}
