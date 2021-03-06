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
    /// Body
    /// </summary>
    [DataContract]
    public partial class Body :  IEquatable<Body>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body" /> class.
        /// </summary>
        /// <param name="List">List name..</param>
        /// <param name="Count">Item count..</param>
        /// <param name="Page">Page number..</param>
        /// <param name="WhereType">Optional enumerator. You can assign the mode of implementation of where criterions by using AND and OR types under whereType parameter..</param>
        /// <param name="Where">Where.</param>
        /// <param name="Order">Order.</param>
        public Body(string List = default(string), int? Count = default(int?), int? Page = default(int?), string WhereType = default(string), List<WhereItem> Where = default(List<WhereItem>), ListOrder Order = default(ListOrder))
        {
            this.List = List;
            this.Count = Count;
            this.Page = Page;
            this.WhereType = WhereType;
            this.Where = Where;
            this.Order = Order;
        }
        
        /// <summary>
        /// List name.
        /// </summary>
        /// <value>List name.</value>
        [DataMember(Name="list", EmitDefaultValue=false)]
        public string List { get; set; }
        /// <summary>
        /// Item count.
        /// </summary>
        /// <value>Item count.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// Page number.
        /// </summary>
        /// <value>Page number.</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }
        /// <summary>
        /// Optional enumerator. You can assign the mode of implementation of where criterions by using AND and OR types under whereType parameter.
        /// </summary>
        /// <value>Optional enumerator. You can assign the mode of implementation of where criterions by using AND and OR types under whereType parameter.</value>
        [DataMember(Name="whereType", EmitDefaultValue=false)]
        public string WhereType { get; set; }
        /// <summary>
        /// Gets or Sets Where
        /// </summary>
        [DataMember(Name="where", EmitDefaultValue=false)]
        public List<WhereItem> Where { get; set; }
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public ListOrder Order { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body {\n");
            sb.Append("  List: ").Append(List).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  WhereType: ").Append(WhereType).Append("\n");
            sb.Append("  Where: ").Append(Where).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(obj as Body);
        }

        /// <summary>
        /// Returns true if Body instances are equal
        /// </summary>
        /// <param name="other">Instance of Body to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.List == other.List ||
                    this.List != null &&
                    this.List.Equals(other.List)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.WhereType == other.WhereType ||
                    this.WhereType != null &&
                    this.WhereType.Equals(other.WhereType)
                ) && 
                (
                    this.Where == other.Where ||
                    this.Where != null &&
                    this.Where.SequenceEqual(other.Where)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
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
                if (this.List != null)
                    hash = hash * 59 + this.List.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.WhereType != null)
                    hash = hash * 59 + this.WhereType.GetHashCode();
                if (this.Where != null)
                    hash = hash * 59 + this.Where.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
