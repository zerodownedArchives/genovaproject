using System;
using System.Collections;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	public class GrandpaCharley : BaseVendor
	{
		protected ArrayList m_SBInfos = new ArrayList();
		protected override ArrayList SBInfos{ get { return m_SBInfos; } }
		
		public override bool IsActiveVendor{ get{ return false; } }
		public override bool CanTeach{ get{ return false; } }
		public override bool IsInvulnerable{ get{ return true; } }
		
		public override void InitSBInfo()
		{		
		}
		
		[Constructable]
		public GrandpaCharley() : base( "the farmer" )
		{			
			Name = "Grandpa Charley";
		}
		
		public GrandpaCharley( Serial serial ) : base( serial )
		{
		}
		
		public override void InitBody()
		{
			InitStats( 100, 100, 25 );
			
			Female = false;
			CantWalk = false;
			Race = Race.Human;
			
			Hue = 0x8410;
			HairItemID = 0x203B;
			HairHue = 0x3B2;	
			FacialHairItemID = 0x203E;
			FacialHairHue = 0x3B2;				
		}
		
		public override void InitOutfit()
		{
			AddItem( new Backpack() );
			AddItem( new ShepherdsCrook() );
			AddItem( new Shoes( 0x72F ) );
			AddItem( new LongPants( 0x519 ) );
			AddItem( new FancyShirt( 0x600 ) );
			AddItem( new WideBrimHat( 0x6B1 ) );
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
	}
}