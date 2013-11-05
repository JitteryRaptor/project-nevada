use strict;
use warnings;

system("cls");

print "Please enter the name of the file: \n" ;
my $file = <STDIN>;
chop $file;

# my $file = 'Project Nevada Presets.ini';
open my $info, $file or die "Could not open $file: $!";
open (DATAFILE, "+>Long Keys.txt");

# Read the input file line by line
while (<$info>) {

	# Plugin prefix
	
	# $_ =~ s/PNxC//g;
	# $_ =~ s/PNxR//g;
	# $_ =~ s/PNxBR//g;
	# $_ =~ s/PNxB//g;
	
	# Standard words
	$_ =~ s/(?!Energy|Ent)En/Enable/g;
	$_ =~ s/Cfg/Config/g;
	$_ =~ s(?!Strength)/St/Stealth/g;
	$_ =~ s/Fld/Field/g;
	$_ =~ s/Perc/Percentage/g;
	$_ =~ s/Cond/Condition/g;
	$_ =~ s/Dam/Damage/g;
	$_ =~ s/End/Endurance/g;
	$_ =~ s/Ind/Indicator/g;
	$_ =~ s/Stab/Stability/g;
	$_ =~ s/Hl/Health/g;
	$_ =~ s/Pen/Penalty/g;
	$_ =~ s/Crip/Crippled/g;
	$_ =~ s/Phy/Physics/g;
	$_ =~ s/Ar/Armor/g;
	
	$_ =~ s/BT/BulletTime/g;
	print DATAFILE $_; 
}


close $file;
close DATAFILE;