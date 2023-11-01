﻿using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Mdels;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournaments";
        public PersonModel createPerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.cnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.firstName);
                p.Add("@LastName", model.lastName);
                p.Add("@EmailAddress", model.emailAddress);
                p.Add("@CellphoneNumber", model.cellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                //id is the output parameter,
                //0 is the default value,
                //dbType is the type of the parameter,
                //direction is the direction of the parameter
                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.id = p.Get<int>("@id");
                return model;
            }
        }

        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel createPrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.cnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.placeNumber);
                p.Add("@PlaceName", model.placeName);
                p.Add("@PrizeAmount", model.prizeAmount);
                p.Add("@PrizePercentage", model.prizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                //id is the output parameter,
                //0 is the default value,
                //dbType is the type of the parameter,
                //direction is the direction of the parameter
                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.id = p.Get<int>("@id");
                return model;
            }
        }

        public TeamModel createTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.cnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.teamName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                //id is the output parameter,
                //0 is the default value,
                //dbType is the type of the parameter,
                //direction is the direction of the parameter
                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                model.id = p.Get<int>("@id");

                foreach (PersonModel tm in model.teamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.id);
                    p.Add("@PersonId", tm.id);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    //id is the output parameter,
                    //0 is the default value,
                    //dbType is the type of the parameter,
                    //direction is the direction of the parameter
                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                }
                return model;
            }
            throw new NotImplementedException();
        }

        public List<PersonModel> getPerson_All()
        {
            List<PersonModel>? output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.cnnString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }
            return output ?? new List<PersonModel>();
            throw new NotImplementedException();
        }

        public List<TeamModel> getTeam_All()
        {
            List<TeamModel>? output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.cnnString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();
                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.id);
                    team.teamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            return output ?? new List<TeamModel>();
            throw new NotImplementedException();
        }
    }
}
