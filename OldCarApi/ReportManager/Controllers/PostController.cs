﻿using OldCarApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OldCarApi.Controllers
{
    public class PostController : ApiController
    {
        PostModel postModel = new PostModel();
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = postModel.Selectalldata();

                return Ok(dt);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public string Post(PostModel objPost)
        {
            string result = postModel.Insertdata(objPost);
            return result;
        }

        [HttpPut]
        public string Put(PostModel objPost)
        {
            string result = postModel.Updatedata(objPost);
            return result;
        }

        [HttpDelete]
        public string Delete(string ID)
        {
            string result = postModel.DeleteData(ID);
            return result;
        }

        [Route("api/Post/GetDataById/{ID}")]
        [HttpGet]
        public IHttpActionResult GetDataById(string ID)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = postModel.SelectDataById(ID);

                return Ok(dt);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }
    }
}