/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.18
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
using OpenAPIDateConverter = eZmaxinc/eZmax-SDK-csharp.Client.OpenAPIDateConverter;

namespace eZmaxinc/eZmax-SDK-csharp.Model
{
    /// <summary>
    /// An Address Object
    /// </summary>
    [DataContract]
    public partial class AddressRequest :  IEquatable<AddressRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressRequest" /> class.
        /// </summary>
        /// <param name="fkiAddresstypeID">The unique ID of the Addresstype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| |3|Real Estate Invoice| |4|Invoicing| |5|Shipping| (required).</param>
        /// <param name="sAddressCivic">The Civic number. (required).</param>
        /// <param name="sAddressStreet">The Street Name (required).</param>
        /// <param name="sAddressSuite">The Suite or appartment number (required).</param>
        /// <param name="sAddressCity">The City name (required).</param>
        /// <param name="fkiProvinceID">The unique ID of the Province.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|(Canada) Alberta |2|(Canada) British Columbia| |3|(Canada) Manitoba| |3|(Canada) Manitoba| |4|(Canada) New Brunswick| |5|(Canada) Newfoundland| |6|(Canada) Northwest Territories| |7|(Canada) Nova Scotia| |8|(Canada) Nunavut| |9|(Canada) Ontario| |10|(Canada) Prince Edward Island| |11|(Canada) Quebec| |12|(Canada) Saskatchewan| |13|(Canada) Yukon| |14|(United-States) Alabama| |15|(United-States) Alaska| |16|(United-States) Arizona| |17|(United-States) Arkansas| |18|(United-States) California| |19|(United-States) Colorado| |20|(United-States) Connecticut| |21|(United-States) Delaware| |22|(United-States) District of Columbia| |23|(United-States) Florida| |24|(United-States) Georgia| |25|(United-States) Hawaii| |26|(United-States) Idaho| |27|(United-States) Illinois| |28|(United-States) Indiana| |29|(United-States) Iowa| |30|(United-States) Kansas| |31|(United-States) Kentucky| |32|(United-States) Louisiane| |33|(United-States) Maine| |34|(United-States) Maryland| |35|(United-States) Massachusetts| |36|(United-States) Michigan| |37|(United-States) Minnesota| |38|(United-States) Mississippi| |39|(United-States) Missouri| |40|(United-States) Montana| |41|(United-States) Nebraska| |42|(United-States) Nevada| |43|(United-States) New Hampshire| |44|(United-States) New Jersey| |45|(United-States) New Mexico| |46|(United-States) New York| |47|(United-States) North Carolina| |48|(United-States) North Dakota| |49|(United-States) Ohio| |50|(United-States) Oklahoma| |51|(United-States) Oregon| |52|(United-States) Pennsylvania| |53|(United-States) Rhode Island| |54|(United-States) South Carolina| |55|(United-States) South Dakota| |56|(United-States) Tennessee| |57|(United-States) Texas| |58|(United-States) Utah| |60|(United-States) Vermont| |59|(United-States) Virginia| |61|(United-States) Washington| |62|(United-States) West Virginia| |63|(United-States) Wisconsin| |64|(United-States) Wyoming| (required).</param>
        /// <param name="fkiCountryID">The unique ID of the Country.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|Canada| |2|United-States| (required).</param>
        /// <param name="sAddressZip">The Postal/Zip Code  The value must be entered without spaces (required).</param>
        public AddressRequest(int fkiAddresstypeID = default(int), string sAddressCivic = default(string), string sAddressStreet = default(string), string sAddressSuite = default(string), string sAddressCity = default(string), int fkiProvinceID = default(int), int fkiCountryID = default(int), string sAddressZip = default(string))
        {
            // to ensure "fkiAddresstypeID" is required (not null)
            if (fkiAddresstypeID == null)
            {
                throw new InvalidDataException("fkiAddresstypeID is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.fkiAddresstypeID = fkiAddresstypeID;
            }
            
            // to ensure "sAddressCivic" is required (not null)
            if (sAddressCivic == null)
            {
                throw new InvalidDataException("sAddressCivic is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.sAddressCivic = sAddressCivic;
            }
            
            // to ensure "sAddressStreet" is required (not null)
            if (sAddressStreet == null)
            {
                throw new InvalidDataException("sAddressStreet is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.sAddressStreet = sAddressStreet;
            }
            
            // to ensure "sAddressSuite" is required (not null)
            if (sAddressSuite == null)
            {
                throw new InvalidDataException("sAddressSuite is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.sAddressSuite = sAddressSuite;
            }
            
            // to ensure "sAddressCity" is required (not null)
            if (sAddressCity == null)
            {
                throw new InvalidDataException("sAddressCity is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.sAddressCity = sAddressCity;
            }
            
            // to ensure "fkiProvinceID" is required (not null)
            if (fkiProvinceID == null)
            {
                throw new InvalidDataException("fkiProvinceID is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.fkiProvinceID = fkiProvinceID;
            }
            
            // to ensure "fkiCountryID" is required (not null)
            if (fkiCountryID == null)
            {
                throw new InvalidDataException("fkiCountryID is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.fkiCountryID = fkiCountryID;
            }
            
            // to ensure "sAddressZip" is required (not null)
            if (sAddressZip == null)
            {
                throw new InvalidDataException("sAddressZip is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.sAddressZip = sAddressZip;
            }
            
        }
        
        /// <summary>
        /// The unique ID of the Addresstype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| |3|Real Estate Invoice| |4|Invoicing| |5|Shipping|
        /// </summary>
        /// <value>The unique ID of the Addresstype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| |3|Real Estate Invoice| |4|Invoicing| |5|Shipping|</value>
        [DataMember(Name="fkiAddresstypeID", EmitDefaultValue=true)]
        public int fkiAddresstypeID { get; set; }

        /// <summary>
        /// The Civic number.
        /// </summary>
        /// <value>The Civic number.</value>
        [DataMember(Name="sAddressCivic", EmitDefaultValue=true)]
        public string sAddressCivic { get; set; }

        /// <summary>
        /// The Street Name
        /// </summary>
        /// <value>The Street Name</value>
        [DataMember(Name="sAddressStreet", EmitDefaultValue=true)]
        public string sAddressStreet { get; set; }

        /// <summary>
        /// The Suite or appartment number
        /// </summary>
        /// <value>The Suite or appartment number</value>
        [DataMember(Name="sAddressSuite", EmitDefaultValue=true)]
        public string sAddressSuite { get; set; }

        /// <summary>
        /// The City name
        /// </summary>
        /// <value>The City name</value>
        [DataMember(Name="sAddressCity", EmitDefaultValue=true)]
        public string sAddressCity { get; set; }

        /// <summary>
        /// The unique ID of the Province.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|(Canada) Alberta |2|(Canada) British Columbia| |3|(Canada) Manitoba| |3|(Canada) Manitoba| |4|(Canada) New Brunswick| |5|(Canada) Newfoundland| |6|(Canada) Northwest Territories| |7|(Canada) Nova Scotia| |8|(Canada) Nunavut| |9|(Canada) Ontario| |10|(Canada) Prince Edward Island| |11|(Canada) Quebec| |12|(Canada) Saskatchewan| |13|(Canada) Yukon| |14|(United-States) Alabama| |15|(United-States) Alaska| |16|(United-States) Arizona| |17|(United-States) Arkansas| |18|(United-States) California| |19|(United-States) Colorado| |20|(United-States) Connecticut| |21|(United-States) Delaware| |22|(United-States) District of Columbia| |23|(United-States) Florida| |24|(United-States) Georgia| |25|(United-States) Hawaii| |26|(United-States) Idaho| |27|(United-States) Illinois| |28|(United-States) Indiana| |29|(United-States) Iowa| |30|(United-States) Kansas| |31|(United-States) Kentucky| |32|(United-States) Louisiane| |33|(United-States) Maine| |34|(United-States) Maryland| |35|(United-States) Massachusetts| |36|(United-States) Michigan| |37|(United-States) Minnesota| |38|(United-States) Mississippi| |39|(United-States) Missouri| |40|(United-States) Montana| |41|(United-States) Nebraska| |42|(United-States) Nevada| |43|(United-States) New Hampshire| |44|(United-States) New Jersey| |45|(United-States) New Mexico| |46|(United-States) New York| |47|(United-States) North Carolina| |48|(United-States) North Dakota| |49|(United-States) Ohio| |50|(United-States) Oklahoma| |51|(United-States) Oregon| |52|(United-States) Pennsylvania| |53|(United-States) Rhode Island| |54|(United-States) South Carolina| |55|(United-States) South Dakota| |56|(United-States) Tennessee| |57|(United-States) Texas| |58|(United-States) Utah| |60|(United-States) Vermont| |59|(United-States) Virginia| |61|(United-States) Washington| |62|(United-States) West Virginia| |63|(United-States) Wisconsin| |64|(United-States) Wyoming|
        /// </summary>
        /// <value>The unique ID of the Province.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|(Canada) Alberta |2|(Canada) British Columbia| |3|(Canada) Manitoba| |3|(Canada) Manitoba| |4|(Canada) New Brunswick| |5|(Canada) Newfoundland| |6|(Canada) Northwest Territories| |7|(Canada) Nova Scotia| |8|(Canada) Nunavut| |9|(Canada) Ontario| |10|(Canada) Prince Edward Island| |11|(Canada) Quebec| |12|(Canada) Saskatchewan| |13|(Canada) Yukon| |14|(United-States) Alabama| |15|(United-States) Alaska| |16|(United-States) Arizona| |17|(United-States) Arkansas| |18|(United-States) California| |19|(United-States) Colorado| |20|(United-States) Connecticut| |21|(United-States) Delaware| |22|(United-States) District of Columbia| |23|(United-States) Florida| |24|(United-States) Georgia| |25|(United-States) Hawaii| |26|(United-States) Idaho| |27|(United-States) Illinois| |28|(United-States) Indiana| |29|(United-States) Iowa| |30|(United-States) Kansas| |31|(United-States) Kentucky| |32|(United-States) Louisiane| |33|(United-States) Maine| |34|(United-States) Maryland| |35|(United-States) Massachusetts| |36|(United-States) Michigan| |37|(United-States) Minnesota| |38|(United-States) Mississippi| |39|(United-States) Missouri| |40|(United-States) Montana| |41|(United-States) Nebraska| |42|(United-States) Nevada| |43|(United-States) New Hampshire| |44|(United-States) New Jersey| |45|(United-States) New Mexico| |46|(United-States) New York| |47|(United-States) North Carolina| |48|(United-States) North Dakota| |49|(United-States) Ohio| |50|(United-States) Oklahoma| |51|(United-States) Oregon| |52|(United-States) Pennsylvania| |53|(United-States) Rhode Island| |54|(United-States) South Carolina| |55|(United-States) South Dakota| |56|(United-States) Tennessee| |57|(United-States) Texas| |58|(United-States) Utah| |60|(United-States) Vermont| |59|(United-States) Virginia| |61|(United-States) Washington| |62|(United-States) West Virginia| |63|(United-States) Wisconsin| |64|(United-States) Wyoming|</value>
        [DataMember(Name="fkiProvinceID", EmitDefaultValue=true)]
        public int fkiProvinceID { get; set; }

        /// <summary>
        /// The unique ID of the Country.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|Canada| |2|United-States|
        /// </summary>
        /// <value>The unique ID of the Country.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|Canada| |2|United-States|</value>
        [DataMember(Name="fkiCountryID", EmitDefaultValue=true)]
        public int fkiCountryID { get; set; }

        /// <summary>
        /// The Postal/Zip Code  The value must be entered without spaces
        /// </summary>
        /// <value>The Postal/Zip Code  The value must be entered without spaces</value>
        [DataMember(Name="sAddressZip", EmitDefaultValue=true)]
        public string sAddressZip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressRequest {\n");
            sb.Append("  fkiAddresstypeID: ").Append(fkiAddresstypeID).Append("\n");
            sb.Append("  sAddressCivic: ").Append(sAddressCivic).Append("\n");
            sb.Append("  sAddressStreet: ").Append(sAddressStreet).Append("\n");
            sb.Append("  sAddressSuite: ").Append(sAddressSuite).Append("\n");
            sb.Append("  sAddressCity: ").Append(sAddressCity).Append("\n");
            sb.Append("  fkiProvinceID: ").Append(fkiProvinceID).Append("\n");
            sb.Append("  fkiCountryID: ").Append(fkiCountryID).Append("\n");
            sb.Append("  sAddressZip: ").Append(sAddressZip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddressRequest);
        }

        /// <summary>
        /// Returns true if AddressRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiAddresstypeID == input.fkiAddresstypeID ||
                    (this.fkiAddresstypeID != null &&
                    this.fkiAddresstypeID.Equals(input.fkiAddresstypeID))
                ) && 
                (
                    this.sAddressCivic == input.sAddressCivic ||
                    (this.sAddressCivic != null &&
                    this.sAddressCivic.Equals(input.sAddressCivic))
                ) && 
                (
                    this.sAddressStreet == input.sAddressStreet ||
                    (this.sAddressStreet != null &&
                    this.sAddressStreet.Equals(input.sAddressStreet))
                ) && 
                (
                    this.sAddressSuite == input.sAddressSuite ||
                    (this.sAddressSuite != null &&
                    this.sAddressSuite.Equals(input.sAddressSuite))
                ) && 
                (
                    this.sAddressCity == input.sAddressCity ||
                    (this.sAddressCity != null &&
                    this.sAddressCity.Equals(input.sAddressCity))
                ) && 
                (
                    this.fkiProvinceID == input.fkiProvinceID ||
                    (this.fkiProvinceID != null &&
                    this.fkiProvinceID.Equals(input.fkiProvinceID))
                ) && 
                (
                    this.fkiCountryID == input.fkiCountryID ||
                    (this.fkiCountryID != null &&
                    this.fkiCountryID.Equals(input.fkiCountryID))
                ) && 
                (
                    this.sAddressZip == input.sAddressZip ||
                    (this.sAddressZip != null &&
                    this.sAddressZip.Equals(input.sAddressZip))
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
                if (this.fkiAddresstypeID != null)
                    hashCode = hashCode * 59 + this.fkiAddresstypeID.GetHashCode();
                if (this.sAddressCivic != null)
                    hashCode = hashCode * 59 + this.sAddressCivic.GetHashCode();
                if (this.sAddressStreet != null)
                    hashCode = hashCode * 59 + this.sAddressStreet.GetHashCode();
                if (this.sAddressSuite != null)
                    hashCode = hashCode * 59 + this.sAddressSuite.GetHashCode();
                if (this.sAddressCity != null)
                    hashCode = hashCode * 59 + this.sAddressCity.GetHashCode();
                if (this.fkiProvinceID != null)
                    hashCode = hashCode * 59 + this.fkiProvinceID.GetHashCode();
                if (this.fkiCountryID != null)
                    hashCode = hashCode * 59 + this.fkiCountryID.GetHashCode();
                if (this.sAddressZip != null)
                    hashCode = hashCode * 59 + this.sAddressZip.GetHashCode();
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
