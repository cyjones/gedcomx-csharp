// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Atom {

  /// <remarks>
  ///  &lt;p&gt;The Atom data formats provide a format for web content and metadata syndication. The XML media type is defined by
  ///  &lt;a href=&quot;http://tools.ietf.org/html/rfc4287#section-4&quot;&gt;RFC 4287&lt;/a&gt;. The JSON data format is specific to GEDCOM X and is a
  ///  translation to JSON from the XML.&lt;/p&gt;
  /// </remarks>
  /// <summary>
  ///  &lt;p&gt;The Atom data formats provide a format for web content and metadata syndication. The XML media type is defined by
  ///  &lt;a href=&quot;http://tools.ietf.org/html/rfc4287#section-4&quot;&gt;RFC 4287&lt;/a&gt;. The JSON data format is specific to GEDCOM X and is a
  ///  translation to JSON from the XML.&lt;/p&gt;
  /// </summary>
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2005/Atom",TypeName="Feed")]
  [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.w3.org/2005/Atom",TypeName="Feed")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.w3.org/2005/Atom",ElementName="feed")]
  public partial class Feed : Gx.Atom.ExtensibleElement {

    private System.Collections.Generic.List<Gx.Atom.Person> _authors;
    private System.Collections.Generic.List<Gx.Atom.Person> _contributors;
    private Gx.Atom.Generator _generator;
    private string _icon;
    private string _id;
    private int? _results;
    private bool _resultsSpecified;
    private int? _index;
    private bool _indexSpecified;
    private System.Collections.Generic.List<Gx.Links.Link> _links;
    private string _logo;
    private string _rights;
    private string _subtitle;
    private string _title;
    private DateTime? _updated;
    private bool _updatedSpecified;
    private System.Collections.Generic.List<Gx.Atom.Entry> _entries;
    private System.Collections.Generic.List<Gx.Records.Field> _facets;
    /// <summary>
    ///  The author of the feed.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="author",Namespace="http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="author")]
    public System.Collections.Generic.List<Gx.Atom.Person> Authors {
      get {
        return this._authors;
      }
      set {
        this._authors = value;
      }
    }
    /// <summary>
    ///  information about a category associated with the feed
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="contributor",Namespace="http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="contributor")]
    public System.Collections.Generic.List<Gx.Atom.Person> Contributors {
      get {
        return this._contributors;
      }
      set {
        this._contributors = value;
      }
    }
    /// <summary>
    ///  identifies the agent used to generate the feed
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="generator",Namespace="http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="generator")]
    public Gx.Atom.Generator Generator {
      get {
        return this._generator;
      }
      set {
        this._generator = value;
      }
    }
    /// <summary>
    ///  identifies an image that provides iconic visual identification for the feed.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="icon",Namespace="http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="icon")]
    public string Icon {
      get {
        return this._icon;
      }
      set {
        this._icon = value;
      }
    }
    /// <summary>
    ///  a permanent, universally unique identifier for the feed.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="id",Namespace="http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="id")]
    public string Id {
      get {
        return this._id;
      }
      set {
        this._id = value;
      }
    }
    /// <summary>
    ///  The total number of results available, if this feed is supplying a subset of results, such as for a query.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="results",Namespace="http://gedcomx.org/v1/")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="results")]
    public int Results {
      get {
        return this._results.GetValueOrDefault();
      }
      set {
        this._results = value;
        this._resultsSpecified = true;
      }
    }

    /// <summary>
    ///  Property for the XML serializer indicating whether the "Results" property should be included in the output.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    [System.Xml.Serialization.SoapIgnoreAttribute]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public bool ResultsSpecified {
      get {
        return this._resultsSpecified;
      }
      set {
        this._resultsSpecified = value;
      }
    }

    /// <summary>
    ///  The index of the first entry in this page of data, if this feed is supplying a page of data.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="index",Namespace="http://gedcomx.org/v1/")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="index")]
    public int Index {
      get {
        return this._index.GetValueOrDefault();
      }
      set {
        this._index = value;
        this._indexSpecified = true;
      }
    }

    /// <summary>
    ///  Property for the XML serializer indicating whether the "Index" property should be included in the output.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    [System.Xml.Serialization.SoapIgnoreAttribute]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public bool IndexSpecified {
      get {
        return this._indexSpecified;
      }
      set {
        this._indexSpecified = value;
      }
    }

    /// <summary>
    ///  a reference from a feed to a Web resource.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="link",Namespace="http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="link")]
    public System.Collections.Generic.List<Gx.Links.Link> Links {
      get {
        return this._links;
      }
      set {
        this._links = value;
      }
    }
    /// <summary>
    ///  identifies an image that provides visual identification for the feed.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="logo",Namespace="http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="logo")]
    public string Logo {
      get {
        return this._logo;
      }
      set {
        this._logo = value;
      }
    }
    /// <summary>
    ///  information about rights held in and over the feed.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="rights",Namespace="http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="rights")]
    public string Rights {
      get {
        return this._rights;
      }
      set {
        this._rights = value;
      }
    }
    /// <summary>
    ///  a human-readable description or subtitle for the feed.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="subtitle",Namespace="http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="subtitle")]
    public string Subtitle {
      get {
        return this._subtitle;
      }
      set {
        this._subtitle = value;
      }
    }
    /// <summary>
    ///  a human-readable title for the feed
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="title",Namespace="http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="title")]
    public string Title {
      get {
        return this._title;
      }
      set {
        this._title = value;
      }
    }
    /// <summary>
    ///  the most recent instant in time when the feed was modified in a way the publisher considers significant.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="updated",Namespace="http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="updated")]
    public DateTime Updated {
      get {
        return this._updated.GetValueOrDefault();
      }
      set {
        this._updated = value;
        this._updatedSpecified = true;
      }
    }

    /// <summary>
    ///  Property for the XML serializer indicating whether the "Updated" property should be included in the output.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    [System.Xml.Serialization.SoapIgnoreAttribute]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public bool UpdatedSpecified {
      get {
        return this._updatedSpecified;
      }
      set {
        this._updatedSpecified = value;
      }
    }

    /// <summary>
    ///  The entries in the feed.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="entry",Namespace="http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="entry")]
    public System.Collections.Generic.List<Gx.Atom.Entry> Entries {
      get {
        return this._entries;
      }
      set {
        this._entries = value;
      }
    }
    /// <summary>
    ///  The list of facets for the feed, used for convenience in browsing and filtering.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="facet",Namespace="http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="facet")]
    public System.Collections.Generic.List<Gx.Records.Field> Facets {
      get {
        return this._facets;
      }
      set {
        this._facets = value;
      }
    }
  }
}  
