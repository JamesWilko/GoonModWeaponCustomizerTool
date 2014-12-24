using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponCustomizationTool {
	public static class Strings {

		public static string MaterialConfigExtension = "*.material_config";
		public static string WeaponFileNameCheck = "wpn_";

		public static string NoExtractFolder = "Error: No extract folder has been specified.";
		public static string ExtractFolderDoesNotExist = "Error: Extract folder does not exist.";
		public static string NoModsFolder = "Error: No mods override folder has been specified.";
		public static string ModsFolderDoesNotExist = "Error: Mods folder does not exist.";

		public static string ProcessingFileStarted = "Processing file: {0}";
		public static string ProcessingFileComplete = "...Done";
		public static string ProcessingAllComplete = "Finished processing {0} material_configs, {1} weapon materials modified...";

		public static string WeaponRendererRegex = "(generic:[\\w:]+)";
		public static string WeaponBumpMapRegex = "(<bump_normal_texture.*)";
		public static string MaskDefaultRenderer = "solid_mask:DEPTH_SCALING";

		public static string DefaultReflectionTexture = "<reflection_texture file=\"units/payday2/matcaps/matcap_plastic_df\"/>\n";
		public static string DefaultMaterialTexture = "<material_texture file=\"units/payday2/masks/shared_textures/patterns/pattern_no_color_no_material_df\"/>\n";
		public static string DefaultColourA = "<variable value=\"1 0 0\" type=\"vector3\" name=\"tint_color_a\"/>\n";
		public static string DefaultColourB = "<variable value=\"0 1 0\" type=\"vector3\" name=\"tint_color_b\"/>\n";
		public static string DefaultMaterialAmount = "<variable value=\"1\" type=\"scalar\" name=\"material_amount\"/>";

	}
}
