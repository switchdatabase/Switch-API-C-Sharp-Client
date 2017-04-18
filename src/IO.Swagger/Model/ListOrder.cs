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
    /// ListOrder
    /// </summary>
    [DataContract]
    public partial class ListOrder :  IEquatable<ListOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrder" /> class.
        /// </summary>
        /// <param name="Type">Order types: ASC, DESC.</param>
        /// <param name="By">Column name..</param>
        public ListOrder(string Type = default(string), string By = default(string))
        {
            this.Type = Type;
            this.By = By;
        }
        
        /// <summary>
        /// Order types: ASC, DESC
        /// </summary>
        /// <value>Order types: ASC, DESC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Column name.
        /// </summary>
        /// <value>Column name.</value>
        [DataMember(Name="by", EmitDefaultValue=false)]
        public string By { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOrder {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  By: ").Append(By).Append("\n");
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
            return this.Equals(obj as ListOrder);
        }

        /// <summary>
        /// Returns true if ListOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of ListOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListOrder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.By == other.By ||
                    this.By != null &&
                    this.By.Equals(other.By)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.By != null)
                    hash = hash * 59 + this.By.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
