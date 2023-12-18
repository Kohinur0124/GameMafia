using Dapper;
using GameMafia.Core.MafiaModels.Interface;
using GameMafia.Core.MafiaModels.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMafia.Core.MafiaModels.Services
{
    public  class ChatService : IMessage<ChatMessage>
    {
        public string connectionString { get; set; } = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=0124; Database=MafiaMessage;";

       
        public List<ChatMessage> Gets()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"select * from public.ChatMessage";
                var messages = connection.Query<ChatMessage>(sqlQuery);
                //var user = connection.QueryFirst<User>(sqlQuery);

                return (List<ChatMessage>)messages;

            }
        }

        public void Delete(ChatMessage chatMessage)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"delete from public.ChatMessage where Id = @chatmessage.Id";
                var messages = connection.Execute(sqlQuery,chatMessage);
                //var user = connection.QueryFirst<User>(sqlQuery);


            }
        }

        public void Update(ChatMessage chatMessage)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"Update from public.ChatMessage set  Message = @chatmessage.Message where Id = @chatmessage.Id";
                var messages = connection.Query<ChatMessage>(sqlQuery);
                //var user = connection.QueryFirst<User>(sqlQuery);


            }
        }

        public void Create(ChatMessage chatMessage)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"insert into public.ChatMessage (id,message)Values(@id,@message);";
                var messages = connection.Query<ChatMessage>(sqlQuery);
                //var user = connection.QueryFirst<User>(sqlQuery);


            }
        }
    }
}
