use strict;
use warnings;

system("cls");

my $file = 'Project Nevada Presets.ini';
open my $info, $file or die "Could not open $file: $!";
open (DATAFILE, "+>Check Scripts.txt");

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
	# my $val (@values[0]);
	print (DATAFILE "set iCheck to iCheck + ($values[0] != GetModINI \"Project Nevada Presets/$section/$values[0]\")\n");
}

close $info;