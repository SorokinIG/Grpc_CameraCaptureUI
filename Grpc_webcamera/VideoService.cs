//CameraCaptureUI
using Grpc.Core;
using System.Drawing.Imaging;
using System.Drawing;



namespace Grpc_webcamera
{
    public class VideoService:Messenger.MessengerBase
    {
        string[] messages = {  };
     

        public VideoService()
        {
            
            
            
          
        }

        public override async Task DataStream(IAsyncStreamReader<Request> requestStream,
            IServerStreamWriter<Response> responseStream,
            ServerCallContext context)
        {
            // считываем входящие сообщения в фоновой задаче
            var readTask = Task.Run(async () =>
            {
                await foreach (Request message in requestStream.ReadAllAsync())
                {
                    Console.WriteLine($"Client: {message.Content}");
                }
            });

            while (true)
            {
                // Посылаем ответ, пока клиент не закроет поток
                //  if (!readTask.IsCompleted)
                //  {                              
                    if ()
                {
                   
                    await responseStream.WriteAsync(new Response { Data = );                                        
                }                   
               // }
            }
            await readTask; // ожидаем завершения задачи чтения
        }



       
        
    }
}
