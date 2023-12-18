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
    public class GroupService : IMessage<GroupMessage>
    {
        public string connectionString { get; set; } = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=0124; Database=MafiaMessage;";


        public List<GroupMessage> Gets()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"select * from public.GroupMessage";
                var messages = connection.Query<GroupMessage>(sqlQuery);
                //var user = connection.QueryFirst<User>(sqlQuery);

                return (List<GroupMessage>)messages;

            }
        }

        public void Delete(GroupMessage groupMessage)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"delete from public.GroupMessage where Id = @groupMessage.Id";
                var messages = connection.Execute(sqlQuery, groupMessage);
                //var user = connection.QueryFirst<User>(sqlQuery);


            }
        }

        public void Update(GroupMessage groupMessage)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"Update from public.GroupMessage set  Message = @groupMessage.Message where Id = @groupMessage.Id";
                var messages = connection.Query<GroupMessage>(sqlQuery);
                //var user = connection.QueryFirst<User>(sqlQuery);


            }
        }

        public void Create(GroupMessage groupMessage)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"insert into public.GroupMessage (id,message)Values(@id,@message);";
                var messages = connection.Query<GroupMessage>(sqlQuery);
                //var user = connection.QueryFirst<User>(sqlQuery);


            }
        }
    }
}
