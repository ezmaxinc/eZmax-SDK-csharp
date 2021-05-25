/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.43
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
    /// An Ezsignsignature Object and children to create a complete structure
    /// </summary>
    [DataContract]
    public partial class EzsignsignatureRequestCompound :  IEquatable<EzsignsignatureRequestCompound>, IValidatableObject
    {
        /// <summary>
        /// The type of signature required.  1. **Acknowledgement** is for an acknowledgment of receipt. 2. **Handwritten** is for a handwritten kind of signature where users needs to \&quot;draw\&quot; their signature on screen. 3. **Initials** is a simple \&quot;click to add initials\&quot; block. 4. **Name** is a simple \&quot;Click to sign\&quot; block. This is the most common block of signature.
        /// </summary>
        /// <value>The type of signature required.  1. **Acknowledgement** is for an acknowledgment of receipt. 2. **Handwritten** is for a handwritten kind of signature where users needs to \&quot;draw\&quot; their signature on screen. 3. **Initials** is a simple \&quot;click to add initials\&quot; block. 4. **Name** is a simple \&quot;Click to sign\&quot; block. This is the most common block of signature.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EEzsignsignatureTypeEnum
        {
            /// <summary>
            /// Enum Acknowledgement for value: Acknowledgement
            /// </summary>
            [EnumMember(Value = "Acknowledgement")]
            Acknowledgement = 1,

            /// <summary>
            /// Enum Handwritten for value: Handwritten
            /// </summary>
            [EnumMember(Value = "Handwritten")]
            Handwritten = 2,

            /// <summary>
            /// Enum Initials for value: Initials
            /// </summary>
            [EnumMember(Value = "Initials")]
            Initials = 3,

            /// <summary>
            /// Enum Name for value: Name
            /// </summary>
            [EnumMember(Value = "Name")]
            Name = 4

        }

        /// <summary>
        /// The type of signature required.  1. **Acknowledgement** is for an acknowledgment of receipt. 2. **Handwritten** is for a handwritten kind of signature where users needs to \&quot;draw\&quot; their signature on screen. 3. **Initials** is a simple \&quot;click to add initials\&quot; block. 4. **Name** is a simple \&quot;Click to sign\&quot; block. This is the most common block of signature.
        /// </summary>
        /// <value>The type of signature required.  1. **Acknowledgement** is for an acknowledgment of receipt. 2. **Handwritten** is for a handwritten kind of signature where users needs to \&quot;draw\&quot; their signature on screen. 3. **Initials** is a simple \&quot;click to add initials\&quot; block. 4. **Name** is a simple \&quot;Click to sign\&quot; block. This is the most common block of signature.</value>
        [DataMember(Name="eEzsignsignatureType", EmitDefaultValue=true)]
        public EEzsignsignatureTypeEnum EEzsignsignatureType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignatureRequestCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignsignatureRequestCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignatureRequestCompound" /> class.
        /// </summary>
        /// <param name="fkiEzsignfoldersignerassociationID">A reference to a valid Ezsignfoldersignerassociation.  That value is returned after a successful Ezsignfoldersignerassociation Creation.  (required).</param>
        /// <param name="iEzsignpagePagenumber">The page number in the document where to apply the signature (required).</param>
        /// <param name="iEzsignsignatureX">The X coordinate (Horizontal) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate. (required).</param>
        /// <param name="iEzsignsignatureY">The Y coordinate (Vertical) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate. (required).</param>
        /// <param name="iEzsignsignatureStep">The step when the Ezsignsigner will be invited to sign.  For example, if you say iEzsignsignatureStep&#x3D;2, that block of signature will be available for signature only after ALL the signatures in step 1 are completed. (required).</param>
        /// <param name="eEzsignsignatureType">The type of signature required.  1. **Acknowledgement** is for an acknowledgment of receipt. 2. **Handwritten** is for a handwritten kind of signature where users needs to \&quot;draw\&quot; their signature on screen. 3. **Initials** is a simple \&quot;click to add initials\&quot; block. 4. **Name** is a simple \&quot;Click to sign\&quot; block. This is the most common block of signature. (required).</param>
        /// <param name="fkiEzsigndocumentID">A reference to a valid Ezsigndocument.  That value is returned after a successful Ezsigndocumentation Creation. (required).</param>
        public EzsignsignatureRequestCompound(int fkiEzsignfoldersignerassociationID = default(int), int iEzsignpagePagenumber = default(int), int iEzsignsignatureX = default(int), int iEzsignsignatureY = default(int), int iEzsignsignatureStep = default(int), EEzsignsignatureTypeEnum eEzsignsignatureType = default(EEzsignsignatureTypeEnum), int fkiEzsigndocumentID = default(int))
        {
            // to ensure "fkiEzsignfoldersignerassociationID" is required (not null)
            if (fkiEzsignfoldersignerassociationID == null)
            {
                throw new InvalidDataException("fkiEzsignfoldersignerassociationID is a required property for EzsignsignatureRequestCompound and cannot be null");
            }
            else
            {
                this.FkiEzsignfoldersignerassociationID = fkiEzsignfoldersignerassociationID;
            }

            // to ensure "iEzsignpagePagenumber" is required (not null)
            if (iEzsignpagePagenumber == null)
            {
                throw new InvalidDataException("iEzsignpagePagenumber is a required property for EzsignsignatureRequestCompound and cannot be null");
            }
            else
            {
                this.IEzsignpagePagenumber = iEzsignpagePagenumber;
            }

            // to ensure "iEzsignsignatureX" is required (not null)
            if (iEzsignsignatureX == null)
            {
                throw new InvalidDataException("iEzsignsignatureX is a required property for EzsignsignatureRequestCompound and cannot be null");
            }
            else
            {
                this.IEzsignsignatureX = iEzsignsignatureX;
            }

            // to ensure "iEzsignsignatureY" is required (not null)
            if (iEzsignsignatureY == null)
            {
                throw new InvalidDataException("iEzsignsignatureY is a required property for EzsignsignatureRequestCompound and cannot be null");
            }
            else
            {
                this.IEzsignsignatureY = iEzsignsignatureY;
            }

            // to ensure "iEzsignsignatureStep" is required (not null)
            if (iEzsignsignatureStep == null)
            {
                throw new InvalidDataException("iEzsignsignatureStep is a required property for EzsignsignatureRequestCompound and cannot be null");
            }
            else
            {
                this.IEzsignsignatureStep = iEzsignsignatureStep;
            }

            // to ensure "eEzsignsignatureType" is required (not null)
            if (eEzsignsignatureType == null)
            {
                throw new InvalidDataException("eEzsignsignatureType is a required property for EzsignsignatureRequestCompound and cannot be null");
            }
            else
            {
                this.EEzsignsignatureType = eEzsignsignatureType;
            }

            // to ensure "fkiEzsigndocumentID" is required (not null)
            if (fkiEzsigndocumentID == null)
            {
                throw new InvalidDataException("fkiEzsigndocumentID is a required property for EzsignsignatureRequestCompound and cannot be null");
            }
            else
            {
                this.FkiEzsigndocumentID = fkiEzsigndocumentID;
            }

        }

        /// <summary>
        /// A reference to a valid Ezsignfoldersignerassociation.  That value is returned after a successful Ezsignfoldersignerassociation Creation. 
        /// </summary>
        /// <value>A reference to a valid Ezsignfoldersignerassociation.  That value is returned after a successful Ezsignfoldersignerassociation Creation. </value>
        [DataMember(Name="fkiEzsignfoldersignerassociationID", EmitDefaultValue=true)]
        public int FkiEzsignfoldersignerassociationID { get; set; }

        /// <summary>
        /// The page number in the document where to apply the signature
        /// </summary>
        /// <value>The page number in the document where to apply the signature</value>
        [DataMember(Name="iEzsignpagePagenumber", EmitDefaultValue=true)]
        public int IEzsignpagePagenumber { get; set; }

        /// <summary>
        /// The X coordinate (Horizontal) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate.
        /// </summary>
        /// <value>The X coordinate (Horizontal) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate.</value>
        [DataMember(Name="iEzsignsignatureX", EmitDefaultValue=true)]
        public int IEzsignsignatureX { get; set; }

        /// <summary>
        /// The Y coordinate (Vertical) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate.
        /// </summary>
        /// <value>The Y coordinate (Vertical) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate.</value>
        [DataMember(Name="iEzsignsignatureY", EmitDefaultValue=true)]
        public int IEzsignsignatureY { get; set; }

        /// <summary>
        /// The step when the Ezsignsigner will be invited to sign.  For example, if you say iEzsignsignatureStep&#x3D;2, that block of signature will be available for signature only after ALL the signatures in step 1 are completed.
        /// </summary>
        /// <value>The step when the Ezsignsigner will be invited to sign.  For example, if you say iEzsignsignatureStep&#x3D;2, that block of signature will be available for signature only after ALL the signatures in step 1 are completed.</value>
        [DataMember(Name="iEzsignsignatureStep", EmitDefaultValue=true)]
        public int IEzsignsignatureStep { get; set; }


        /// <summary>
        /// A reference to a valid Ezsigndocument.  That value is returned after a successful Ezsigndocumentation Creation.
        /// </summary>
        /// <value>A reference to a valid Ezsigndocument.  That value is returned after a successful Ezsigndocumentation Creation.</value>
        [DataMember(Name="fkiEzsigndocumentID", EmitDefaultValue=true)]
        public int FkiEzsigndocumentID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignsignatureRequestCompound {\n");
            sb.Append("  FkiEzsignfoldersignerassociationID: ").Append(FkiEzsignfoldersignerassociationID).Append("\n");
            sb.Append("  IEzsignpagePagenumber: ").Append(IEzsignpagePagenumber).Append("\n");
            sb.Append("  IEzsignsignatureX: ").Append(IEzsignsignatureX).Append("\n");
            sb.Append("  IEzsignsignatureY: ").Append(IEzsignsignatureY).Append("\n");
            sb.Append("  IEzsignsignatureStep: ").Append(IEzsignsignatureStep).Append("\n");
            sb.Append("  EEzsignsignatureType: ").Append(EEzsignsignatureType).Append("\n");
            sb.Append("  FkiEzsigndocumentID: ").Append(FkiEzsigndocumentID).Append("\n");
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
            return this.Equals(input as EzsignsignatureRequestCompound);
        }

        /// <summary>
        /// Returns true if EzsignsignatureRequestCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignsignatureRequestCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignsignatureRequestCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FkiEzsignfoldersignerassociationID == input.FkiEzsignfoldersignerassociationID ||
                    (this.FkiEzsignfoldersignerassociationID != null &&
                    this.FkiEzsignfoldersignerassociationID.Equals(input.FkiEzsignfoldersignerassociationID))
                ) && 
                (
                    this.IEzsignpagePagenumber == input.IEzsignpagePagenumber ||
                    (this.IEzsignpagePagenumber != null &&
                    this.IEzsignpagePagenumber.Equals(input.IEzsignpagePagenumber))
                ) && 
                (
                    this.IEzsignsignatureX == input.IEzsignsignatureX ||
                    (this.IEzsignsignatureX != null &&
                    this.IEzsignsignatureX.Equals(input.IEzsignsignatureX))
                ) && 
                (
                    this.IEzsignsignatureY == input.IEzsignsignatureY ||
                    (this.IEzsignsignatureY != null &&
                    this.IEzsignsignatureY.Equals(input.IEzsignsignatureY))
                ) && 
                (
                    this.IEzsignsignatureStep == input.IEzsignsignatureStep ||
                    (this.IEzsignsignatureStep != null &&
                    this.IEzsignsignatureStep.Equals(input.IEzsignsignatureStep))
                ) && 
                (
                    this.EEzsignsignatureType == input.EEzsignsignatureType ||
                    (this.EEzsignsignatureType != null &&
                    this.EEzsignsignatureType.Equals(input.EEzsignsignatureType))
                ) && 
                (
                    this.FkiEzsigndocumentID == input.FkiEzsigndocumentID ||
                    (this.FkiEzsigndocumentID != null &&
                    this.FkiEzsigndocumentID.Equals(input.FkiEzsigndocumentID))
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
                if (this.FkiEzsignfoldersignerassociationID != null)
                    hashCode = hashCode * 59 + this.FkiEzsignfoldersignerassociationID.GetHashCode();
                if (this.IEzsignpagePagenumber != null)
                    hashCode = hashCode * 59 + this.IEzsignpagePagenumber.GetHashCode();
                if (this.IEzsignsignatureX != null)
                    hashCode = hashCode * 59 + this.IEzsignsignatureX.GetHashCode();
                if (this.IEzsignsignatureY != null)
                    hashCode = hashCode * 59 + this.IEzsignsignatureY.GetHashCode();
                if (this.IEzsignsignatureStep != null)
                    hashCode = hashCode * 59 + this.IEzsignsignatureStep.GetHashCode();
                if (this.EEzsignsignatureType != null)
                    hashCode = hashCode * 59 + this.EEzsignsignatureType.GetHashCode();
                if (this.FkiEzsigndocumentID != null)
                    hashCode = hashCode * 59 + this.FkiEzsigndocumentID.GetHashCode();
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
