/* 
 * Switch Database REST API
 *
 * Switch API is the primary endpoint of data sevices and Switch DB's platform. You can do adding, editing, deleting or listing data works to your database with query operations by using this low-level API based on HTTP.
 *
 * OpenAPI spec version: 1.2.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// AddResponse
    /// </summary>
    [DataContract]
    public partial class AddResponse :  IEquatable<AddResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddResponse" /> class.
        /// </summary>
        /// <param name="ResponseTime">ResponseTime.</param>
        /// <param name="Response">Response.</param>
        /// <param name="ListItemId">ListItemId.</param>
        public AddResponse(long? ResponseTime = default(long?), string Response = default(string), string ListItemId = default(string))
        {
            this.ResponseTime = ResponseTime;
            this.Response = Response;
            this.ListItemId = ListItemId;
        }
        
        /// <summary>
        /// Gets or Sets ResponseTime
        /// </summary>
        [DataMember(Name="ResponseTime", EmitDefaultValue=false)]
        public long? ResponseTime { get; set; }
        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name="Response", EmitDefaultValue=false)]
        public string Response { get; set; }
        /// <summary>
        /// Gets or Sets ListItemId
        /// </summary>
        [DataMember(Name="ListItemId", EmitDefaultValue=false)]
        public string ListItemId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddResponse {\n");
            sb.Append("  ResponseTime: ").Append(ResponseTime).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  ListItemId: ").Append(ListItemId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AddResponse);
        }

        /// <summary>
        /// Returns true if AddResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AddResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ResponseTime == other.ResponseTime ||
                    this.ResponseTime != null &&
                    this.ResponseTime.Equals(other.ResponseTime)
                ) && 
                (
                    this.Response == other.Response ||
                    this.Response != null &&
                    this.Response.Equals(other.Response)
                ) && 
                (
                    this.ListItemId == other.ListItemId ||
                    this.ListItemId != null &&
                    this.ListItemId.Equals(other.ListItemId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ResponseTime != null)
                    hash = hash * 59 + this.ResponseTime.GetHashCode();
                if (this.Response != null)
                    hash = hash * 59 + this.Response.GetHashCode();
                if (this.ListItemId != null)
                    hash = hash * 59 + this.ListItemId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}