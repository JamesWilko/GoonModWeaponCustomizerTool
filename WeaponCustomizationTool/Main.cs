using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WeaponCustomizationTool {
	public partial class Main : Form {

		string extractFolder = "D:/Steam/steamapps/common/PAYDAY 2/assets/extract";
		string modsFolder = "D:/Steam/steamapps/common/PAYDAY 2/assets/mod_overrides";

		List<string> extractPaths = new List<string>();

		public Main() {

			InitializeComponent();

			progressBar.Enabled = false;
			txtExtractFolder.Text = extractFolder;
			txtModsFolder.Text = modsFolder;

		}

		private void toolStripAboutButton_Click( object sender, EventArgs e ) {
			About about = new About();
			about.ShowDialog();
		}

		private void txtExtractFolder_KeyDown( object sender, KeyEventArgs e ) {

			if ( e.KeyCode == Keys.Return ) {
				if ( !string.IsNullOrEmpty( txtExtractFolder.Text ) ) {
					extractFolder = txtExtractFolder.Text;
				}
			}

		}

		private void btnBrowseExtractFolder_Click( object sender, EventArgs e ) {

			folderExtractDialog.ShowDialog();
			string path = folderExtractDialog.SelectedPath;
			if ( !string.IsNullOrEmpty( path ) ) {
				extractFolder = path;
				txtExtractFolder.Text = path;
			}

		}

		private void txtModsFolder_KeyDown( object sender, KeyEventArgs e ) {

			if ( e.KeyCode == Keys.Return ) {
				if ( !string.IsNullOrEmpty( txtModsFolder.Text ) ) {
					modsFolder = txtModsFolder.Text;
				}
			}

		}

		private void btnBrowseModsFolder_Click( object sender, EventArgs e ) {

			folderModsDialog.ShowDialog();
			string path = folderModsDialog.SelectedPath;
			if ( !string.IsNullOrEmpty( path ) ) {
				modsFolder = path;
				txtModsFolder.Text = path;
			}

		}

		private void btnProcessFolders_Click( object sender, EventArgs e ) {

			ClearConsole();

			WriteToConsole( "Extract folder:" + extractFolder );
			WriteToConsole( "Mod overrides folder:" + modsFolder );

			// Check folders have been specified
			if ( string.IsNullOrEmpty( extractFolder ) ) {
				WriteToConsole( Strings.NoExtractFolder );
				return;
			}

			if ( string.IsNullOrEmpty( modsFolder ) ) {
				WriteToConsole( Strings.NoModsFolder );
				return;
			}

			// Check folders exist
			if ( !Directory.Exists( extractFolder ) ) {
				WriteToConsole( Strings.ExtractFolderDoesNotExist );
				return;
			}

			if ( !Directory.Exists( modsFolder ) ) {
				WriteToConsole( Strings.ModsFolderDoesNotExist );
				return;
			}

			// Enable progress bar
			progressBar.Enabled = true;

			string[] materialConfigs = Directory.GetFiles( extractFolder, Strings.MaterialConfigExtension, SearchOption.AllDirectories );
			extractPaths = materialConfigs.Where( x => x.Contains( Strings.WeaponFileNameCheck ) ).ToList();

			string path = "";
			for ( int i = 0; i < extractPaths.Count; i++ ) {
				
				path = extractPaths[i];

				WriteToConsole( string.Format( Strings.ProcessingFileStarted, path.Replace( extractFolder, "" ) ) );
				ProcessMaterialConfigFile( path );
				WriteToConsole( Strings.ProcessingFileComplete );
				progressBar.Value = (int) Math.Round( (float) i / (float) extractPaths.Count * 100f );

			}

			progressBar.Value = 100;
			WriteToConsole( string.Format( Strings.ProcessingAllComplete, materialConfigs.Length, extractPaths.Count ) );

		}

		void ClearConsole() {
			txtConsole.Text = "";
		}

		void WriteToConsole(string s) {
			Console.WriteLine( s );
			s = s.Replace( "\n", Environment.NewLine );
			txtConsole.AppendText( s + Environment.NewLine );
		}

		void ProcessMaterialConfigFile( string directory ) {

			string destination = directory.Replace( extractFolder, modsFolder );

			// Create destination path
			FileInfo destFile = new FileInfo( destination );
			destFile.Directory.Create();

			// Read information from source file
			StreamReader reader = new StreamReader( directory );
			string congfigData = reader.ReadToEnd();
			string newConfigData = congfigData;

			// Add data to material config
			Regex rendererRegex = new Regex( Strings.WeaponRendererRegex );
			Regex bumpMapRegex = new Regex( Strings.WeaponBumpMapRegex );
			newConfigData = rendererRegex.Replace( congfigData, Strings.MaskDefaultRenderer );

			foreach ( var m in bumpMapRegex.Matches( congfigData ) ) {
				string data = m.ToString();
				data += "\n" + Strings.DefaultReflectionTexture + Strings.DefaultMaterialTexture + Strings.DefaultColourA + Strings.DefaultColourB + Strings.DefaultMaterialAmount;
				newConfigData = newConfigData.Replace( m.ToString(), data );
			}

			// Write data to file
			StreamWriter writer = new StreamWriter( destination, false, Encoding.UTF8 );
			writer.Write( newConfigData );

			// Close streams
			reader.Close();
			writer.Close();

		}

	}
}
