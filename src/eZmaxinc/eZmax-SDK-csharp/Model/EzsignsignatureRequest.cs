/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.19
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
    /// An Ezsignsignature Object
    /// </summary>
    [DataContract]
    public partial class EzsignsignatureRequest :  IEquatable<EzsignsignatureRequest>, IValidatableObject
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
        public EEzsignsignatureTypeEnum eEzsignsignatureType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignatureRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignsignatureRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignatureRequest" /> class.
        /// </summary>
        /// <param name="fkiEzsignfoldersignerassociationID">A reference to a valid Ezsignfoldersignerassociation.  That value is returned after a successful Ezsignfoldersignerassociation Creation.  (required).</param>
        /// <param name="iEzsignpagePagenumber">The page number in the document where to apply the signature (required).</param>
        /// <param name="iEzsignsignatureX">The X coordinate (Horizontal) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate. (required).</param>
        /// <param name="iEzsignsignatureY">The Y coordinate (Vertical) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate. (required).</param>
        /// <param name="iEzsignsignatureStep">The step when the Ezsignsigner will be invited to sign.  For example, if you say iEzsignsignatureStep&#x3D;2, that block of signature will be available for signature only after ALL the signatures in step 1 are completed. (required).</param>
        /// <param name="eEzsignsignatureType">The type of signature required.  1. **Acknowledgement** is for an acknowledgment of receipt. 2. **Handwritten** is for a handwritten kind of signature where users needs to \&quot;draw\&quot; their signature on screen. 3. **Initials** is a simple \&quot;click to add initials\&quot; block. 4. **Name** is a simple \&quot;Click to sign\&quot; block. This is the most common block of signature. (required).</param>
        /// <param name="fkiEzsigndocumentID">A reference to a valid Ezsigndocument.  That value is returned after a successful Ezsigndocumentation Creation. (required).</param>
        public EzsignsignatureRequest(int fkiEzsignfoldersignerassociationID = default(int), int iEzsignpagePagenumber = default(int), int iEzsignsignatureX = default(int), int iEzsignsignatureY = default(int), int iEzsignsignatureStep = default(int), EEzsignsignatureTypeEnum eEzsignsignatureType = default(EEzsignsignatureTypeEnum), int fkiEzsigndocumentID = default(int))
        {
            // to ensure "fkiEzsignfoldersignerassociationID" is required (not null)
            if (fkiEzsignfoldersignerassociationID == null)
            {
                throw new InvalidDataException("fkiEzsignfoldersignerassociationID is a required property for EzsignsignatureRequest and cannot be null");
            }
            else
            {
                this.fkiEzsignfoldersignerassociationID = fkiEzsignfoldersignerassociationID;
            }
            
            // to ensure "iEzsignpagePagenumber" is required (not null)
            if (iEzsignpagePagenumber == null)
            {
                throw new InvalidDataException("iEzsignpagePagenumber is a required property for EzsignsignatureRequest and cannot be null");
            }
            else
            {
                this.iEzsignpagePagenumber = iEzsignpagePagenumber;
            }
            
            // to ensure "iEzsignsignatureX" is required (not null)
            if (iEzsignsignatureX == null)
            {
                throw new InvalidDataException("iEzsignsignatureX is a required property for EzsignsignatureRequest and cannot be null");
            }
            else
            {
                this.iEzsignsignatureX = iEzsignsignatureX;
            }
            
            // to ensure "iEzsignsignatureY" is required (not null)
            if (iEzsignsignatureY == null)
            {
                throw new InvalidDataException("iEzsignsignatureY is a required property for EzsignsignatureRequest and cannot be null");
            }
            else
            {
                this.iEzsignsignatureY = iEzsignsignatureY;
            }
            
            // to ensure "iEzsignsignatureStep" is required (not null)
            if (iEzsignsignatureStep == null)
            {
                throw new InvalidDataException("iEzsignsignatureStep is a required property for EzsignsignatureRequest and cannot be null");
            }
            else
            {
                this.iEzsignsignatureStep = iEzsignsignatureStep;
            }
            
            // to ensure "eEzsignsignatureType" is required (not null)
            if (eEzsignsignatureType == null)
            {
                throw new InvalidDataException("eEzsignsignatureType is a required property for EzsignsignatureRequest and cannot be null");
            }
            else
            {
                this.eEzsignsignatureType = eEzsignsignatureType;
            }
            
            // to ensure "fkiEzsigndocumentID" is required (not null)
            if (fkiEzsigndocumentID == null)
            {
                throw new InvalidDataException("fkiEzsigndocumentID is a required property for EzsignsignatureRequest and cannot be null");
            }
            else
            {
                this.fkiEzsigndocumentID = fkiEzsigndocumentID;
            }
            
        }
        
        /// <summary>
        /// A reference to a valid Ezsignfoldersignerassociation.  That value is returned after a successful Ezsignfoldersignerassociation Creation. 
        /// </summary>
        /// <value>A reference to a valid Ezsignfoldersignerassociation.  That value is returned after a successful Ezsignfoldersignerassociation Creation. </value>
        [DataMember(Name="fkiEzsignfoldersignerassociationID", EmitDefaultValue=true)]
        public int fkiEzsignfoldersignerassociationID { get; set; }

        /// <summary>
        /// The page number in the document where to apply the signature
        /// </summary>
        /// <value>The page number in the document where to apply the signature</value>
        [DataMember(Name="iEzsignpagePagenumber", EmitDefaultValue=true)]
        public int iEzsignpagePagenumber { get; set; }

        /// <summary>
        /// The X coordinate (Horizontal) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate.
        /// </summary>
        /// <value>The X coordinate (Horizontal) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate.</value>
        [DataMember(Name="iEzsignsignatureX", EmitDefaultValue=true)]
        public int iEzsignsignatureX { get; set; }

        /// <summary>
        /// The Y coordinate (Vertical) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate.
        /// </summary>
        /// <value>The Y coordinate (Vertical) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate.</value>
        [DataMember(Name="iEzsignsignatureY", EmitDefaultValue=true)]
        public int iEzsignsignatureY { get; set; }

        /// <summary>
        /// The step when the Ezsignsigner will be invited to sign.  For example, if you say iEzsignsignatureStep&#x3D;2, that block of signature will be available for signature only after ALL the signatures in step 1 are completed.
        /// </summary>
        /// <value>The step when the Ezsignsigner will be invited to sign.  For example, if you say iEzsignsignatureStep&#x3D;2, that block of signature will be available for signature only after ALL the signatures in step 1 are completed.</value>
        [DataMember(Name="iEzsignsignatureStep", EmitDefaultValue=true)]
        public int iEzsignsignatureStep { get; set; }


        /// <summary>
        /// A reference to a valid Ezsigndocument.  That value is returned after a successful Ezsigndocumentation Creation.
        /// </summary>
        /// <value>A reference to a valid Ezsigndocument.  That value is returned after a successful Ezsigndocumentation Creation.</value>
        [DataMember(Name="fkiEzsigndocumentID", EmitDefaultValue=true)]
        public int fkiEzsigndocumentID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignsignatureRequest {\n");
            sb.Append("  fkiEzsignfoldersignerassociationID: ").Append(fkiEzsignfoldersignerassociationID).Append("\n");
            sb.Append("  iEzsignpagePagenumber: ").Append(iEzsignpagePagenumber).Append("\n");
            sb.Append("  iEzsignsignatureX: ").Append(iEzsignsignatureX).Append("\n");
            sb.Append("  iEzsignsignatureY: ").Append(iEzsignsignatureY).Append("\n");
            sb.Append("  iEzsignsignatureStep: ").Append(iEzsignsignatureStep).Append("\n");
            sb.Append("  eEzsignsignatureType: ").Append(eEzsignsignatureType).Append("\n");
            sb.Append("  fkiEzsigndocumentID: ").Append(fkiEzsigndocumentID).Append("\n");
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
            return this.Equals(input as EzsignsignatureRequest);
        }

        /// <summary>
        /// Returns true if EzsignsignatureRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignsignatureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignsignatureRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiEzsignfoldersignerassociationID == input.fkiEzsignfoldersignerassociationID ||
                    (this.fkiEzsignfoldersignerassociationID != null &&
                    this.fkiEzsignfoldersignerassociationID.Equals(input.fkiEzsignfoldersignerassociationID))
                ) && 
                (
                    this.iEzsignpagePagenumber == input.iEzsignpagePagenumber ||
                    (this.iEzsignpagePagenumber != null &&
                    this.iEzsignpagePagenumber.Equals(input.iEzsignpagePagenumber))
                ) && 
                (
                    this.iEzsignsignatureX == input.iEzsignsignatureX ||
                    (this.iEzsignsignatureX != null &&
                    this.iEzsignsignatureX.Equals(input.iEzsignsignatureX))
                ) && 
                (
                    this.iEzsignsignatureY == input.iEzsignsignatureY ||
                    (this.iEzsignsignatureY != null &&
                    this.iEzsignsignatureY.Equals(input.iEzsignsignatureY))
                ) && 
                (
                    this.iEzsignsignatureStep == input.iEzsignsignatureStep ||
                    (this.iEzsignsignatureStep != null &&
                    this.iEzsignsignatureStep.Equals(input.iEzsignsignatureStep))
                ) && 
                (
                    this.eEzsignsignatureType == input.eEzsignsignatureType ||
                    (this.eEzsignsignatureType != null &&
                    this.eEzsignsignatureType.Equals(input.eEzsignsignatureType))
                ) && 
                (
                    this.fkiEzsigndocumentID == input.fkiEzsigndocumentID ||
                    (this.fkiEzsigndocumentID != null &&
                    this.fkiEzsigndocumentID.Equals(input.fkiEzsigndocumentID))
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
                if (this.fkiEzsignfoldersignerassociationID != null)
                    hashCode = hashCode * 59 + this.fkiEzsignfoldersignerassociationID.GetHashCode();
                if (this.iEzsignpagePagenumber != null)
                    hashCode = hashCode * 59 + this.iEzsignpagePagenumber.GetHashCode();
                if (this.iEzsignsignatureX != null)
                    hashCode = hashCode * 59 + this.iEzsignsignatureX.GetHashCode();
                if (this.iEzsignsignatureY != null)
                    hashCode = hashCode * 59 + this.iEzsignsignatureY.GetHashCode();
                if (this.iEzsignsignatureStep != null)
                    hashCode = hashCode * 59 + this.iEzsignsignatureStep.GetHashCode();
                if (this.eEzsignsignatureType != null)
                    hashCode = hashCode * 59 + this.eEzsignsignatureType.GetHashCode();
                if (this.fkiEzsigndocumentID != null)
                    hashCode = hashCode * 59 + this.fkiEzsigndocumentID.GetHashCode();
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
