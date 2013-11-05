use strict;
use warnings;

system("cls");

print "Please enter the name of the file: \n" ;
my $file = <STDIN>;
chop $file;

# my $file = 'PN Extra Options.ini';
open my $info, $file or die "Could not open $file: $!";
open my $vars, "Variable Names.txt" or die "Could not open file";
open (DATAFILE, "+>Get Scripts.txt");

my @values;
my $section;

while( (my $line1 = <$info>) & (my $line2 = <$vars>))  {
	print $line1;
	next if $line1 =~ /^;/;
	if ($line1 =~ /^\s/) {
		print (DATAFILE "\n");
		next;
	}
	if ($line1 =~ /^\[/) {
		@values = split('\[', $line1);
		$section = (@values[1]);
		$section =~ tr/\$#@~!&*()[];.,:?^ `\\\///d;
		chomp($section);
		print (DATAFILE "\n\n; $section\n");
		next;
	}
	chomp($line2);
	@values = split('=', $line1);
	print (DATAFILE "set $line2 to GetModINI \"PN EO/$section/$values[0]\"\n");
}

close $info;