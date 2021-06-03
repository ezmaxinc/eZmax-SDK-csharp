/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.46
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = eZmaxApi.Client.OpenAPIDateConverter;

namespace eZmaxApi.Model
{
    /// <summary>
    /// Generic Autocomplete Response
    /// </summary>
    [DataContract]
    public partial class CommonGetAutocompleteV1ResponseMPayload :  IEquatable<CommonGetAutocompleteV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonGetAutocompleteV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonGetAutocompleteV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonGetAutocompleteV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="group">The Category (ie group) for the dropdown or an empty string if not categorized (required).</param>
        /// <param name="id">The Unique ID of the element (required).</param>
        /// <param name="option">The Description of the element (required).</param>
        public CommonGetAutocompleteV1ResponseMPayload(string group = default(string), string id = default(string), string option = default(string))
        {
            // to ensure "group" is required (not null)
            if (group == null)
            {
                throw new InvalidDataException("group is a required property for CommonGetAutocompleteV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.Group = group;
            }

            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CommonGetAutocompleteV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "option" is required (not null)
            if (option == null)
            {
                throw new InvalidDataException("option is a required property for CommonGetAutocompleteV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.Option = option;
            }

        }

        /// <summary>
        /// The Category (ie group) for the dropdown or an empty string if not categorized
        /// </summary>
        /// <value>The Category (ie group) for the dropdown or an empty string if not categorized</value>
        [DataMember(Name="group", EmitDefaultValue=true)]
        public string Group { get; set; }

        /// <summary>
        /// The Unique ID of the element
        /// </summary>
        /// <value>The Unique ID of the element</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// The Description of the element
        /// </summary>
        /// <value>The Description of the element</value>
        [DataMember(Name="option", EmitDefaultValue=true)]
        public string Option { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonGetAutocompleteV1ResponseMPayload {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommonGetAutocompleteV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if CommonGetAutocompleteV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonGetAutocompleteV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonGetAutocompleteV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Option == input.Option ||
                    (this.Option != null &&
                    this.Option.Equals(input.Option))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Option != null)
                    hashCode = hashCode * 59 + this.Option.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
