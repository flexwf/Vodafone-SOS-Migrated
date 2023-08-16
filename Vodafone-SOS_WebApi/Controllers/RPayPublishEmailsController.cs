﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Data.SqlClient;
using Vodafone_SOS_WebApi.Models;
using Vodafone_SOS_WebApi.Utilities;
using System.Data.Entity.Validation;

namespace Vodafone_SOS_WebApi.Controllers
{
    public class RPayPublishEmailsController : ApiController
    {
        // GET: RPayPublishEmails
        
        private SOSEDMV10Entities db = new SOSEDMV10Entities();
        public IHttpActionResult GetEmailIDsPayPublishEmailData(int CompanyId)
        {
            var data = db.RPayPublishEmails.Where(p => p.CompanyId == CompanyId).Select(x => new { x.EmailIds, x.Id ,x.CompanyId,x.Department}).OrderBy(p => p.EmailIds).AsEnumerable();
            return Ok(data);
        }

        // PUT: api/RPayPublishEmails/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutRPayPublishEmail(int id, RPayPublishEmail RPayPublishEmail, string UserName, string Workflow)
        {
            if (!ModelState.IsValid)
            {
                //return BadRequest(ModelState);
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, string.Format(Globals.BadRequestErrorMessage, "UPDATE", "PayPublishEmail")));
            }

            if (id != RPayPublishEmail.Id)
            {
                //return BadRequest();
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, string.Format(Globals.BadRequestErrorMessage, "UPDATE", "PayPublishEmail")));
            }

            try
            {
                db.Entry(RPayPublishEmail).State = EntityState.Modified;
                await db.SaveChangesAsync();

            }
            catch (DbEntityValidationException dbex)
            {
                var errorMessage = Globals.GetEntityValidationErrorMessage(dbex);
                throw new HttpResponseException(Request.CreateErrorResponse((HttpStatusCode)Globals.ExceptionType.Type2, errorMessage));//type 2 error
            }
            catch (Exception ex)
            {
                if (ex.GetBaseException().GetType() == typeof(SqlException))//check for exception type
                {
                    //Throw this as HttpResponse Exception to let user know about the mistakes they made, correct them and retry.
                    throw new HttpResponseException(Request.CreateErrorResponse((HttpStatusCode)Globals.ExceptionType.Type2, GetCustomizedErrorMessage(ex)));//type 2 error
                }
                else
                {
                    throw ex;//This exception will be handled in FilterConfig's CustomHandler
                }
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/RPayPublishEmails
        [ResponseType(typeof(RPayPublishEmail))]
        public async Task<IHttpActionResult> PostRPayPublishEmail(RPayPublishEmail RPayPublishEmail, string UserName, string Workflow)
        {
            if (!ModelState.IsValid)
            {
                //return BadRequest(ModelState);
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, string.Format(Globals.BadRequestErrorMessage, "CREATE", "PayPublishEmail")));
            }

            try
            {
                if (db.RPayPublishEmails.Where(p => p.Id == RPayPublishEmail.Id).Where(p => p.CompanyId == RPayPublishEmail.CompanyId).Count() > 0)
                {
                    db.Entry(RPayPublishEmail).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                }
                else
                {
                    RPayPublishEmail.Id = 0;//To override the Id generated by grid
                    db.RPayPublishEmails.Add(RPayPublishEmail);
                    await db.SaveChangesAsync();
                }

            }
            catch (DbEntityValidationException dbex)
            {
                var errorMessage = Globals.GetEntityValidationErrorMessage(dbex);
                throw new HttpResponseException(Request.CreateErrorResponse((HttpStatusCode)Globals.ExceptionType.Type2, errorMessage));//type 2 error
            }
            catch (Exception ex)
            {
                if (ex.GetBaseException().GetType() == typeof(SqlException))//check for exception type
                {
                    //Throw this as HttpResponse Exception to let user know about the mistakes they made, correct them and retry.
                    throw new HttpResponseException(Request.CreateErrorResponse((HttpStatusCode)Globals.ExceptionType.Type2, GetCustomizedErrorMessage(ex)));//type 2 error
                }
                else
                {
                    throw ex;//This exception will be handled in FilterConfig's CustomHandler
                }
            }

            return Ok();
            //return CreatedAtRoute("DefaultApi", new { id = RPayPublishEmail.Id }, RPayPublishEmail);
        }

        // DELETE: api/RPayPublishEmails/5
        [ResponseType(typeof(RPayPublishEmail))]
        public async Task<IHttpActionResult> DeleteRPayPublishEmail(int id, string UserName, string Workflow, int CompanyId)
        {
            RPayPublishEmail RPayPublishEmail = db.RPayPublishEmails.Where(p => p.Id == id).Where(p => p.CompanyId == CompanyId).FirstOrDefault();
            try
            {
                if (RPayPublishEmail != null)
                {
                    db.RPayPublishEmails.Remove(RPayPublishEmail);
                    await db.SaveChangesAsync();
                }

                return Ok(RPayPublishEmail);
            }
            catch (DbEntityValidationException dbex)
            {
                var errorMessage = Globals.GetEntityValidationErrorMessage(dbex);
                throw new HttpResponseException(Request.CreateErrorResponse((HttpStatusCode)Globals.ExceptionType.Type2, errorMessage));//type 2 error
            }
            catch (Exception ex)
            {
                if (ex.GetBaseException().GetType() == typeof(SqlException))//check for exception type
                {
                    //Throw this as HttpResponse Exception to let user know about the mistakes they made, correct them and retry.
                    throw new HttpResponseException(Request.CreateErrorResponse((HttpStatusCode)Globals.ExceptionType.Type2, GetCustomizedErrorMessage(ex)));//type 2 error
                }
                else
                {
                    throw ex;//This exception will be handled in FilterConfig's CustomHandler
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RPayPublishEmailExists(int id)
        {
            return db.RPayPublishEmails.Count(e => e.Id == id) > 0;
        }

        private string GetCustomizedErrorMessage(Exception ex)
        {
            //Convert the exception to SqlException to get the error message returned by database.
            var SqEx = ex.GetBaseException() as SqlException;
                //callGlobals.ExecuteSPLogError SP here and log SQL SqEx.Message
                //Add complete Url in description
                var UserName = "";//System.Web.HttpContext.Current.Session["UserName"] as string;
                string UrlString = Convert.ToString(Request.RequestUri.AbsolutePath);
                var ErrorDesc = "";
                var Desc = Request.GetQueryNameValuePairs().ToDictionary(x => x.Key, x => x.Value);
                if (Desc.Count() > 0)
                    ErrorDesc = string.Join(",", Desc);
                string[] s = Request.RequestUri.AbsolutePath.Split('/');//This array will provide controller name at 2nd and action name at 3 rd index position
                Globals.ExecuteSPLogError("Vodafone-SOS_WebApi", s[2], s[3], SqEx.Message, UserName, "Type2", ErrorDesc, "resolution", "L2Admin", "field", 0, "New");
                //Globals.LogError(SqEx.Message, ErrorDesc);
                return Globals.SomethingElseFailedInDBErrorMessage;
        }
    }
}