using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MarsRovers.Library;

namespace MarsRovers.WebAPI.Controllers
{
    public class RoverController : ApiController
    {
        public class RoverConfig
        {
            public string Plateau { get; set; }
            public string StartPosition { get; set; }
            public string MoveCommands { get; set; }
        }

       
        [HttpPost()]
        public HttpResponseMessage DeployRover([FromBody]  RoverConfig roverconfig)
        {
            try
            {
                Rover rover = null;
                var plateau = Plateau.CreatePlateau(roverconfig.Plateau);
                rover = Rover.CreateRover(roverconfig.StartPosition);
                rover.SetPlateau(plateau);
                rover.ExecuteBatchCmds(roverconfig.MoveCommands);
                return Request.CreateResponse(HttpStatusCode.Created, rover.GetPosition());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message: ex.Message);
            }

        }

        [HttpPost()]
        public HttpResponseMessage GetRoverMoveLog([FromBody]  RoverConfig roverconfig)
        {
            try
            {
                Rover rover = null;
                var plateau = Plateau.CreatePlateau(roverconfig.Plateau);
                rover = Rover.CreateRover(roverconfig.StartPosition);
                rover.SetPlateau(plateau);
                rover.ExecuteBatchCmds(roverconfig.MoveCommands);
                string Result = "[" + rover.MoveLog + "]";
                return Request.CreateResponse(HttpStatusCode.Created, Result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message: ex.Message);
            }

        }
    }
}
