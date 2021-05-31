/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.44
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
                this.FkiAddresstypeID = fkiAddresstypeID;
            }

            // to ensure "sAddressCivic" is required (not null)
            if (sAddressCivic == null)
            {
                throw new InvalidDataException("sAddressCivic is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.SAddressCivic = sAddressCivic;
            }

            // to ensure "sAddressStreet" is required (not null)
            if (sAddressStreet == null)
            {
                throw new InvalidDataException("sAddressStreet is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.SAddressStreet = sAddressStreet;
            }

            // to ensure "sAddressSuite" is required (not null)
            if (sAddressSuite == null)
            {
                throw new InvalidDataException("sAddressSuite is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.SAddressSuite = sAddressSuite;
            }

            // to ensure "sAddressCity" is required (not null)
            if (sAddressCity == null)
            {
                throw new InvalidDataException("sAddressCity is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.SAddressCity = sAddressCity;
            }

            // to ensure "fkiProvinceID" is required (not null)
            if (fkiProvinceID == null)
            {
                throw new InvalidDataException("fkiProvinceID is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.FkiProvinceID = fkiProvinceID;
            }

            // to ensure "fkiCountryID" is required (not null)
            if (fkiCountryID == null)
            {
                throw new InvalidDataException("fkiCountryID is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.FkiCountryID = fkiCountryID;
            }

            // to ensure "sAddressZip" is required (not null)
            if (sAddressZip == null)
            {
                throw new InvalidDataException("sAddressZip is a required property for AddressRequest and cannot be null");
            }
            else
            {
                this.SAddressZip = sAddressZip;
            }

        }

        /// <summary>
        /// The unique ID of the Addresstype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| |3|Real Estate Invoice| |4|Invoicing| |5|Shipping|
        /// </summary>
        /// <value>The unique ID of the Addresstype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| |3|Real Estate Invoice| |4|Invoicing| |5|Shipping|</value>
        [DataMember(Name="fkiAddresstypeID", EmitDefaultValue=true)]
        public int FkiAddresstypeID { get; set; }

        /// <summary>
        /// The Civic number.
        /// </summary>
        /// <value>The Civic number.</value>
        [DataMember(Name="sAddressCivic", EmitDefaultValue=true)]
        public string SAddressCivic { get; set; }

        /// <summary>
        /// The Street Name
        /// </summary>
        /// <value>The Street Name</value>
        [DataMember(Name="sAddressStreet", EmitDefaultValue=true)]
        public string SAddressStreet { get; set; }

        /// <summary>
        /// The Suite or appartment number
        /// </summary>
        /// <value>The Suite or appartment number</value>
        [DataMember(Name="sAddressSuite", EmitDefaultValue=true)]
        public string SAddressSuite { get; set; }

        /// <summary>
        /// The City name
        /// </summary>
        /// <value>The City name</value>
        [DataMember(Name="sAddressCity", EmitDefaultValue=true)]
        public string SAddressCity { get; set; }

        /// <summary>
        /// The unique ID of the Province.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|(Canada) Alberta |2|(Canada) British Columbia| |3|(Canada) Manitoba| |3|(Canada) Manitoba| |4|(Canada) New Brunswick| |5|(Canada) Newfoundland| |6|(Canada) Northwest Territories| |7|(Canada) Nova Scotia| |8|(Canada) Nunavut| |9|(Canada) Ontario| |10|(Canada) Prince Edward Island| |11|(Canada) Quebec| |12|(Canada) Saskatchewan| |13|(Canada) Yukon| |14|(United-States) Alabama| |15|(United-States) Alaska| |16|(United-States) Arizona| |17|(United-States) Arkansas| |18|(United-States) California| |19|(United-States) Colorado| |20|(United-States) Connecticut| |21|(United-States) Delaware| |22|(United-States) District of Columbia| |23|(United-States) Florida| |24|(United-States) Georgia| |25|(United-States) Hawaii| |26|(United-States) Idaho| |27|(United-States) Illinois| |28|(United-States) Indiana| |29|(United-States) Iowa| |30|(United-States) Kansas| |31|(United-States) Kentucky| |32|(United-States) Louisiane| |33|(United-States) Maine| |34|(United-States) Maryland| |35|(United-States) Massachusetts| |36|(United-States) Michigan| |37|(United-States) Minnesota| |38|(United-States) Mississippi| |39|(United-States) Missouri| |40|(United-States) Montana| |41|(United-States) Nebraska| |42|(United-States) Nevada| |43|(United-States) New Hampshire| |44|(United-States) New Jersey| |45|(United-States) New Mexico| |46|(United-States) New York| |47|(United-States) North Carolina| |48|(United-States) North Dakota| |49|(United-States) Ohio| |50|(United-States) Oklahoma| |51|(United-States) Oregon| |52|(United-States) Pennsylvania| |53|(United-States) Rhode Island| |54|(United-States) South Carolina| |55|(United-States) South Dakota| |56|(United-States) Tennessee| |57|(United-States) Texas| |58|(United-States) Utah| |60|(United-States) Vermont| |59|(United-States) Virginia| |61|(United-States) Washington| |62|(United-States) West Virginia| |63|(United-States) Wisconsin| |64|(United-States) Wyoming|
        /// </summary>
        /// <value>The unique ID of the Province.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|(Canada) Alberta |2|(Canada) British Columbia| |3|(Canada) Manitoba| |3|(Canada) Manitoba| |4|(Canada) New Brunswick| |5|(Canada) Newfoundland| |6|(Canada) Northwest Territories| |7|(Canada) Nova Scotia| |8|(Canada) Nunavut| |9|(Canada) Ontario| |10|(Canada) Prince Edward Island| |11|(Canada) Quebec| |12|(Canada) Saskatchewan| |13|(Canada) Yukon| |14|(United-States) Alabama| |15|(United-States) Alaska| |16|(United-States) Arizona| |17|(United-States) Arkansas| |18|(United-States) California| |19|(United-States) Colorado| |20|(United-States) Connecticut| |21|(United-States) Delaware| |22|(United-States) District of Columbia| |23|(United-States) Florida| |24|(United-States) Georgia| |25|(United-States) Hawaii| |26|(United-States) Idaho| |27|(United-States) Illinois| |28|(United-States) Indiana| |29|(United-States) Iowa| |30|(United-States) Kansas| |31|(United-States) Kentucky| |32|(United-States) Louisiane| |33|(United-States) Maine| |34|(United-States) Maryland| |35|(United-States) Massachusetts| |36|(United-States) Michigan| |37|(United-States) Minnesota| |38|(United-States) Mississippi| |39|(United-States) Missouri| |40|(United-States) Montana| |41|(United-States) Nebraska| |42|(United-States) Nevada| |43|(United-States) New Hampshire| |44|(United-States) New Jersey| |45|(United-States) New Mexico| |46|(United-States) New York| |47|(United-States) North Carolina| |48|(United-States) North Dakota| |49|(United-States) Ohio| |50|(United-States) Oklahoma| |51|(United-States) Oregon| |52|(United-States) Pennsylvania| |53|(United-States) Rhode Island| |54|(United-States) South Carolina| |55|(United-States) South Dakota| |56|(United-States) Tennessee| |57|(United-States) Texas| |58|(United-States) Utah| |60|(United-States) Vermont| |59|(United-States) Virginia| |61|(United-States) Washington| |62|(United-States) West Virginia| |63|(United-States) Wisconsin| |64|(United-States) Wyoming|</value>
        [DataMember(Name="fkiProvinceID", EmitDefaultValue=true)]
        public int FkiProvinceID { get; set; }

        /// <summary>
        /// The unique ID of the Country.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|Canada| |2|United-States|
        /// </summary>
        /// <value>The unique ID of the Country.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|Canada| |2|United-States|</value>
        [DataMember(Name="fkiCountryID", EmitDefaultValue=true)]
        public int FkiCountryID { get; set; }

        /// <summary>
        /// The Postal/Zip Code  The value must be entered without spaces
        /// </summary>
        /// <value>The Postal/Zip Code  The value must be entered without spaces</value>
        [DataMember(Name="sAddressZip", EmitDefaultValue=true)]
        public string SAddressZip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressRequest {\n");
            sb.Append("  FkiAddresstypeID: ").Append(FkiAddresstypeID).Append("\n");
            sb.Append("  SAddressCivic: ").Append(SAddressCivic).Append("\n");
            sb.Append("  SAddressStreet: ").Append(SAddressStreet).Append("\n");
            sb.Append("  SAddressSuite: ").Append(SAddressSuite).Append("\n");
            sb.Append("  SAddressCity: ").Append(SAddressCity).Append("\n");
            sb.Append("  FkiProvinceID: ").Append(FkiProvinceID).Append("\n");
            sb.Append("  FkiCountryID: ").Append(FkiCountryID).Append("\n");
            sb.Append("  SAddressZip: ").Append(SAddressZip).Append("\n");
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
                    this.FkiAddresstypeID == input.FkiAddresstypeID ||
                    (this.FkiAddresstypeID != null &&
                    this.FkiAddresstypeID.Equals(input.FkiAddresstypeID))
                ) && 
                (
                    this.SAddressCivic == input.SAddressCivic ||
                    (this.SAddressCivic != null &&
                    this.SAddressCivic.Equals(input.SAddressCivic))
                ) && 
                (
                    this.SAddressStreet == input.SAddressStreet ||
                    (this.SAddressStreet != null &&
                    this.SAddressStreet.Equals(input.SAddressStreet))
                ) && 
                (
                    this.SAddressSuite == input.SAddressSuite ||
                    (this.SAddressSuite != null &&
                    this.SAddressSuite.Equals(input.SAddressSuite))
                ) && 
                (
                    this.SAddressCity == input.SAddressCity ||
                    (this.SAddressCity != null &&
                    this.SAddressCity.Equals(input.SAddressCity))
                ) && 
                (
                    this.FkiProvinceID == input.FkiProvinceID ||
                    (this.FkiProvinceID != null &&
                    this.FkiProvinceID.Equals(input.FkiProvinceID))
                ) && 
                (
                    this.FkiCountryID == input.FkiCountryID ||
                    (this.FkiCountryID != null &&
                    this.FkiCountryID.Equals(input.FkiCountryID))
                ) && 
                (
                    this.SAddressZip == input.SAddressZip ||
                    (this.SAddressZip != null &&
                    this.SAddressZip.Equals(input.SAddressZip))
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
                if (this.FkiAddresstypeID != null)
                    hashCode = hashCode * 59 + this.FkiAddresstypeID.GetHashCode();
                if (this.SAddressCivic != null)
                    hashCode = hashCode * 59 + this.SAddressCivic.GetHashCode();
                if (this.SAddressStreet != null)
                    hashCode = hashCode * 59 + this.SAddressStreet.GetHashCode();
                if (this.SAddressSuite != null)
                    hashCode = hashCode * 59 + this.SAddressSuite.GetHashCode();
                if (this.SAddressCity != null)
                    hashCode = hashCode * 59 + this.SAddressCity.GetHashCode();
                if (this.FkiProvinceID != null)
                    hashCode = hashCode * 59 + this.FkiProvinceID.GetHashCode();
                if (this.FkiCountryID != null)
                    hashCode = hashCode * 59 + this.FkiCountryID.GetHashCode();
                if (this.SAddressZip != null)
                    hashCode = hashCode * 59 + this.SAddressZip.GetHashCode();
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
