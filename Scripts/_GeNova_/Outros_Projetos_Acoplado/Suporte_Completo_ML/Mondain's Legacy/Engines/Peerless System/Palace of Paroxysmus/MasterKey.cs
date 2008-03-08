using System;
using Server;

namespace Server.Items
{
	public class ParoxysmusKey : MasterKey
	{
		public override int LabelNumber{ get{ return 1074330; } } // slimy ointment
		public override int Lifespan{ get{ return 600; } }
		
		public ParoxysmusKey() : base( 0xEFB )
		{
			Weight = 1.0;
			Hue = 0x497;
		}
		
		public ParoxysmusKey( Serial serial ) : base( serial )
		{
		}		
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}
		
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
		
		public override bool CanOfferConfirmation( Mobile from )
		{
			if ( from.Region != null && from.Region.IsPartOf( "Palace of Paroxysmus" ) )
				return true;
				
			return false;
		}
	}
}