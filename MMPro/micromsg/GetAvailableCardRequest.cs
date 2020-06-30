using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "GetAvailableCardRequest")]
	[Serializable]
	public class GetAvailableCardRequest : IExtensible
	{
		private BaseRequest _BaseRequest;

		private string _app_id = "";

		private uint _shop_id = 0u;

		private string _sign_type = "";

		private string _card_sign = "";

		private uint _time_stamp = 0u;

		private string _nonce_str = "";

		private string _card_tp_id = "";

		private string _card_type = "";

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseRequest", DataFormat = DataFormat.Default)]
		public BaseRequest BaseRequest
		{
			get
			{
				return this._BaseRequest;
			}
			set
			{
				this._BaseRequest = value;
			}
		}

		[ProtoMember(2, IsRequired = false, Name = "app_id", DataFormat = DataFormat.Default), DefaultValue("")]
		public string app_id
		{
			get
			{
				return this._app_id;
			}
			set
			{
				this._app_id = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "shop_id", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint shop_id
		{
			get
			{
				return this._shop_id;
			}
			set
			{
				this._shop_id = value;
			}
		}

		[ProtoMember(4, IsRequired = false, Name = "sign_type", DataFormat = DataFormat.Default), DefaultValue("")]
		public string sign_type
		{
			get
			{
				return this._sign_type;
			}
			set
			{
				this._sign_type = value;
			}
		}

		[ProtoMember(5, IsRequired = false, Name = "card_sign", DataFormat = DataFormat.Default), DefaultValue("")]
		public string card_sign
		{
			get
			{
				return this._card_sign;
			}
			set
			{
				this._card_sign = value;
			}
		}

		[ProtoMember(6, IsRequired = false, Name = "time_stamp", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint time_stamp
		{
			get
			{
				return this._time_stamp;
			}
			set
			{
				this._time_stamp = value;
			}
		}

		[ProtoMember(7, IsRequired = false, Name = "nonce_str", DataFormat = DataFormat.Default), DefaultValue("")]
		public string nonce_str
		{
			get
			{
				return this._nonce_str;
			}
			set
			{
				this._nonce_str = value;
			}
		}

		[ProtoMember(8, IsRequired = false, Name = "card_tp_id", DataFormat = DataFormat.Default), DefaultValue("")]
		public string card_tp_id
		{
			get
			{
				return this._card_tp_id;
			}
			set
			{
				this._card_tp_id = value;
			}
		}

		[ProtoMember(9, IsRequired = false, Name = "card_type", DataFormat = DataFormat.Default), DefaultValue("")]
		public string card_type
		{
			get
			{
				return this._card_type;
			}
			set
			{
				this._card_type = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
