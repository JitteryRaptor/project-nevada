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
	
	# $_ =~ s/PNxC//g;
	# $_ =~ s/PNxR//g;
	# $_ =~ s/PNxBR//g;
	# $_ =~ s/PNxB//g;
	
	# Standard words
	$_ =~ s/Enable/En/g;
	$_ =~ s/Config/Cfg/g;
	$_ =~ s/Stealth/St/g;
	$_ =~ s/Field/Fld/g;
	$_ =~ s/Percentage/Perc/g;
	$_ =~ s/Condition/Cond/g;
	$_ =~ s/Damage/Dam/g;
	$_ =~ s/Endurance/End/g;
	$_ =~ s/Indicator/Ind/g;
	$_ =~ s/Stability/Stab/g;
	$_ =~ s/Health/Hl/g;
	$_ =~ s/Penalty/Pen/g;
	$_ =~ s/Crippled/Crip/g;
	$_ =~ s/Physics/Phy/g;
	$_ =~ s/Armor/Ar/g;
	
	$_ =~ s/BulletTime/BT/g;
	print DATAFILE $_; 
}


close $file;
close DATAFILE;