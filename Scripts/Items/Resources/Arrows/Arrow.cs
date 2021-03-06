using System;

namespace Server.Items
{
    [Flipable(3903, 3904, 3905)]
	public class Arrow : Item, ICommodity
	{
        int ICommodity.DescriptionNumber { get { return LabelNumber; } }
        bool ICommodity.IsDeedable { get { return true; } }

		public override double DefaultWeight
		{
			get { return 0.1; }
		}

		[Constructable]
		public Arrow() : this( 1 )
		{
		}

		[Constructable]
		public Arrow( int amount ) : base( 0xF3F )
		{
			Stackable = true;
			Amount = amount;
		}

		public Arrow( Serial serial ) : base( serial )
		{
		}

		

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}