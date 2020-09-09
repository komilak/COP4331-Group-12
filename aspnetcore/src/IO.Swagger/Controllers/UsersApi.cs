/*
 * POOP Group 12 API
 *
 * API for POOP Group 12 contacts app
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class UsersApiController : ControllerBase
    { 
        /// <summary>
        /// Tests endpoint
        /// </summary>
        /// <remarks>Checks if alive</remarks>
        /// <response code="200">I am alive</response>
        /// <response code="404">I am dead :(</response>
        [HttpPost]
        [Route("/PHP//AmAlive.php")]
        [ValidateModelState]
        [SwaggerOperation("AmAlive")]
        public virtual IActionResult AmAlive()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds user to user table
        /// </summary>
        /// <remarks>Adds user into user table</remarks>
        /// <param name="newUser">New user</param>
        /// <response code="200">Successfully created a new user</response>
        /// <response code="404">Could not create user</response>
        [HttpPost]
        [Route("/PHP//CreateUser.php")]
        [ValidateModelState]
        [SwaggerOperation("CreateUserPhpPost")]
        public virtual IActionResult CreateUserPhpPost([FromBody]User newUser)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Logs in to contacts app
        /// </summary>
        /// <remarks>Logs in to contacts app</remarks>
        /// <param name="loginItem">Login</param>
        /// <response code="200">OK</response>
        /// <response code="404">URL Not Found</response>
        [HttpPost]
        [Route("/PHP//Login.php")]
        [ValidateModelState]
        [SwaggerOperation("DoLogin")]
        public virtual IActionResult DoLogin([FromBody]Login loginItem)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }
    }
}
