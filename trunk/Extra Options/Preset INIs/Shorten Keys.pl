use strict;
use warnings;

system("cls");

print "Please enter the name of the file: \n" ;
my $file = <STDIN>;
chop $file;

# my $file = 'Project Nevada Presets.ini';
open my $info, $file or die "Could not open $file: $!";
open (DATAFILE, "+>Short Keys.txt");

# Read the input file line by line
while (<$info>) {

	# Plugin prefix
	
	# $_ =~ s/PNxC//gi;
	# $_ =~ s/PNxR//gi;
	# $_ =~ s/PNxBR//gi;
	# $_ =~ s/PNxB//gi;
	
	# Standard words
	$_ =~ s/Enable/En/gi;
	$_ =~ s/Config/Cfg/gi;
	$_ =~ s/Stealth/St/gi;
	$_ =~ s/Field/Fld/gi;
	$_ =~ s/Percentage/Perc/gi;
	$_ =~ s/Condition/Cond/gi;
	$_ =~ s/Damage/Dam/gi;
	$_ =~ s/Endurance/End/gi;
	$_ =~ s/Indicator/Ind/gi;
	$_ =~ s/Stability/Stab/gi;
	$_ =~ s/Health/Hl/gi;
	$_ =~ s/Penalty/Pen/gi;
	$_ =~ s/Crippled/Crip/gi;
	$_ =~ s/Physics/Phy/gi;
	$_ =~ s/Armor/Ar/gi;
	
	$_ =~ s/BulletTime/BT/gi;
	print DATAFILE $_; 
}


close $file;
close DATAFILE;