// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/promotion_extension_occasion.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/promotion_extension_occasion.proto</summary>
  public static partial class PromotionExtensionOccasionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/promotion_extension_occasion.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PromotionExtensionOccasionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvcHJvbW90aW9uX2V4",
            "dGVuc2lvbl9vY2Nhc2lvbi5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djEwLmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIrwFCh5Q",
            "cm9tb3Rpb25FeHRlbnNpb25PY2Nhc2lvbkVudW0imQUKGlByb21vdGlvbkV4",
            "dGVuc2lvbk9jY2FzaW9uEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThAB",
            "Eg0KCU5FV19ZRUFSUxACEhQKEENISU5FU0VfTkVXX1lFQVIQAxISCg5WQUxF",
            "TlRJTkVTX0RBWRAEEgoKBkVBU1RFUhAFEg8KC01PVEhFUlNfREFZEAYSDwoL",
            "RkFUSEVSU19EQVkQBxINCglMQUJPUl9EQVkQCBISCg5CQUNLX1RPX1NDSE9P",
            "TBAJEg0KCUhBTExPV0VFThAKEhAKDEJMQUNLX0ZSSURBWRALEhAKDENZQkVS",
            "X01PTkRBWRAMEg0KCUNIUklTVE1BUxANEg4KCkJPWElOR19EQVkQDhIUChBJ",
            "TkRFUEVOREVOQ0VfREFZEA8SEAoMTkFUSU9OQUxfREFZEBASEQoNRU5EX09G",
            "X1NFQVNPThAREg8KC1dJTlRFUl9TQUxFEBISDwoLU1VNTUVSX1NBTEUQExIN",
            "CglGQUxMX1NBTEUQFBIPCgtTUFJJTkdfU0FMRRAVEgsKB1JBTUFEQU4QFhIP",
            "CgtFSURfQUxfRklUUhAXEg8KC0VJRF9BTF9BREhBEBgSDwoLU0lOR0xFU19E",
            "QVkQGRIOCgpXT01FTlNfREFZEBoSCAoESE9MSRAbEg8KC1BBUkVOVFNfREFZ",
            "EBwSEwoPU1RfTklDSE9MQVNfREFZEB0SDAoIQ0FSTklWQUwQHhIMCghFUElQ",
            "SEFOWRAfEhEKDVJPU0hfSEFTSEFOQUgQIBIMCghQQVNTT1ZFUhAhEgwKCEhB",
            "TlVLS0FIECISCgoGRElXQUxJECMSDAoITkFWUkFUUkkQJBIMCghTT05HS1JB",
            "ThAlEhEKDVlFQVJfRU5EX0dJRlQQJkL5AQoiY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxMC5lbnVtc0IfUHJvbW90aW9uRXh0ZW5zaW9uT2NjYXNpb25Q",
            "cm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2Fkcy9nb29nbGVhZHMvdjEwL2VudW1zO2VudW1zogIDR0FBqgIeR29vZ2xl",
            "LkFkcy5Hb29nbGVBZHMuVjEwLkVudW1zygIeR29vZ2xlXEFkc1xHb29nbGVB",
            "ZHNcVjEwXEVudW1z6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjEwOjpF",
            "bnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.PromotionExtensionOccasionEnum), global::Google.Ads.GoogleAds.V10.Enums.PromotionExtensionOccasionEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.PromotionExtensionOccasionEnum.Types.PromotionExtensionOccasion) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing a promotion extension occasion.
  /// For more information about the occasions please check:
  /// https://support.google.com/google-ads/answer/7367521
  /// </summary>
  public sealed partial class PromotionExtensionOccasionEnum : pb::IMessage<PromotionExtensionOccasionEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PromotionExtensionOccasionEnum> _parser = new pb::MessageParser<PromotionExtensionOccasionEnum>(() => new PromotionExtensionOccasionEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PromotionExtensionOccasionEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.PromotionExtensionOccasionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PromotionExtensionOccasionEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PromotionExtensionOccasionEnum(PromotionExtensionOccasionEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PromotionExtensionOccasionEnum Clone() {
      return new PromotionExtensionOccasionEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PromotionExtensionOccasionEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PromotionExtensionOccasionEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PromotionExtensionOccasionEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PromotionExtensionOccasionEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// A promotion extension occasion.
      /// </summary>
      public enum PromotionExtensionOccasion {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// New Year's.
        /// </summary>
        [pbr::OriginalName("NEW_YEARS")] NewYears = 2,
        /// <summary>
        /// Chinese New Year.
        /// </summary>
        [pbr::OriginalName("CHINESE_NEW_YEAR")] ChineseNewYear = 3,
        /// <summary>
        /// Valentine's Day.
        /// </summary>
        [pbr::OriginalName("VALENTINES_DAY")] ValentinesDay = 4,
        /// <summary>
        /// Easter.
        /// </summary>
        [pbr::OriginalName("EASTER")] Easter = 5,
        /// <summary>
        /// Mother's Day.
        /// </summary>
        [pbr::OriginalName("MOTHERS_DAY")] MothersDay = 6,
        /// <summary>
        /// Father's Day.
        /// </summary>
        [pbr::OriginalName("FATHERS_DAY")] FathersDay = 7,
        /// <summary>
        /// Labor Day.
        /// </summary>
        [pbr::OriginalName("LABOR_DAY")] LaborDay = 8,
        /// <summary>
        /// Back To School.
        /// </summary>
        [pbr::OriginalName("BACK_TO_SCHOOL")] BackToSchool = 9,
        /// <summary>
        /// Halloween.
        /// </summary>
        [pbr::OriginalName("HALLOWEEN")] Halloween = 10,
        /// <summary>
        /// Black Friday.
        /// </summary>
        [pbr::OriginalName("BLACK_FRIDAY")] BlackFriday = 11,
        /// <summary>
        /// Cyber Monday.
        /// </summary>
        [pbr::OriginalName("CYBER_MONDAY")] CyberMonday = 12,
        /// <summary>
        /// Christmas.
        /// </summary>
        [pbr::OriginalName("CHRISTMAS")] Christmas = 13,
        /// <summary>
        /// Boxing Day.
        /// </summary>
        [pbr::OriginalName("BOXING_DAY")] BoxingDay = 14,
        /// <summary>
        /// Independence Day in any country.
        /// </summary>
        [pbr::OriginalName("INDEPENDENCE_DAY")] IndependenceDay = 15,
        /// <summary>
        /// National Day in any country.
        /// </summary>
        [pbr::OriginalName("NATIONAL_DAY")] NationalDay = 16,
        /// <summary>
        /// End of any season.
        /// </summary>
        [pbr::OriginalName("END_OF_SEASON")] EndOfSeason = 17,
        /// <summary>
        /// Winter Sale.
        /// </summary>
        [pbr::OriginalName("WINTER_SALE")] WinterSale = 18,
        /// <summary>
        /// Summer sale.
        /// </summary>
        [pbr::OriginalName("SUMMER_SALE")] SummerSale = 19,
        /// <summary>
        /// Fall Sale.
        /// </summary>
        [pbr::OriginalName("FALL_SALE")] FallSale = 20,
        /// <summary>
        /// Spring Sale.
        /// </summary>
        [pbr::OriginalName("SPRING_SALE")] SpringSale = 21,
        /// <summary>
        /// Ramadan.
        /// </summary>
        [pbr::OriginalName("RAMADAN")] Ramadan = 22,
        /// <summary>
        /// Eid al-Fitr.
        /// </summary>
        [pbr::OriginalName("EID_AL_FITR")] EidAlFitr = 23,
        /// <summary>
        /// Eid al-Adha.
        /// </summary>
        [pbr::OriginalName("EID_AL_ADHA")] EidAlAdha = 24,
        /// <summary>
        /// Singles Day.
        /// </summary>
        [pbr::OriginalName("SINGLES_DAY")] SinglesDay = 25,
        /// <summary>
        /// Women's Day.
        /// </summary>
        [pbr::OriginalName("WOMENS_DAY")] WomensDay = 26,
        /// <summary>
        /// Holi.
        /// </summary>
        [pbr::OriginalName("HOLI")] Holi = 27,
        /// <summary>
        /// Parent's Day.
        /// </summary>
        [pbr::OriginalName("PARENTS_DAY")] ParentsDay = 28,
        /// <summary>
        /// St. Nicholas Day.
        /// </summary>
        [pbr::OriginalName("ST_NICHOLAS_DAY")] StNicholasDay = 29,
        /// <summary>
        /// Carnival.
        /// </summary>
        [pbr::OriginalName("CARNIVAL")] Carnival = 30,
        /// <summary>
        /// Epiphany, also known as Three Kings' Day.
        /// </summary>
        [pbr::OriginalName("EPIPHANY")] Epiphany = 31,
        /// <summary>
        /// Rosh Hashanah.
        /// </summary>
        [pbr::OriginalName("ROSH_HASHANAH")] RoshHashanah = 32,
        /// <summary>
        /// Passover.
        /// </summary>
        [pbr::OriginalName("PASSOVER")] Passover = 33,
        /// <summary>
        /// Hanukkah.
        /// </summary>
        [pbr::OriginalName("HANUKKAH")] Hanukkah = 34,
        /// <summary>
        /// Diwali.
        /// </summary>
        [pbr::OriginalName("DIWALI")] Diwali = 35,
        /// <summary>
        /// Navratri.
        /// </summary>
        [pbr::OriginalName("NAVRATRI")] Navratri = 36,
        /// <summary>
        /// Available in Thai: Songkran.
        /// </summary>
        [pbr::OriginalName("SONGKRAN")] Songkran = 37,
        /// <summary>
        /// Available in Japanese: Year-end Gift.
        /// </summary>
        [pbr::OriginalName("YEAR_END_GIFT")] YearEndGift = 38,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code