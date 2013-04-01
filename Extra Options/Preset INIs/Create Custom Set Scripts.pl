use strict;
use warnings;

system("cls");

my $file = 'PN Extra Options.ini';
open my $info, $file or die "Could not open $file: $!";
open (DATAFILE, "+>Set Scripts.txt");

my @values;
my $section;

while( my $line = <$info>)  {
	print $line;
	next if $line =~ /^;/;
	if ($line =~ /^\s/) {
		print (DATAFILE "\n");
		next;
	}
	if ($line =~ /^\[/) {
		@values = split('\[', $line);
		$section = (@values[1]);
		$section =~ tr/\$#@~!&*()[];.,:?^ `\\\///d;
		chomp($section);
		print (DATAFILE "\n\n; $section\n");
		next;
	}
	@values = split('=', $line);
	print (DATAFILE "SetModINI \"PN Extra Options/$section/$values[0]\" $values[0]\n");
}

close $info;