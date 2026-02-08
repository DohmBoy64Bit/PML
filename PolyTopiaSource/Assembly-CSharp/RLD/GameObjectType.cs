using System;

namespace RLD
{
	// Token: 0x0200018E RID: 398
	[Flags]
	public enum GameObjectType
	{
		// Token: 0x04001852 RID: 6226
		Mesh = 1,
		// Token: 0x04001853 RID: 6227
		Terrain = 2,
		// Token: 0x04001854 RID: 6228
		Sprite = 4,
		// Token: 0x04001855 RID: 6229
		Camera = 8,
		// Token: 0x04001856 RID: 6230
		Light = 16,
		// Token: 0x04001857 RID: 6231
		ParticleSystem = 32,
		// Token: 0x04001858 RID: 6232
		Empty = 64
	}
}
