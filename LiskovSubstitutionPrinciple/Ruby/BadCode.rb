

class Bird
  attr_accessor :kind

  def fly
    puts "The #{@kind} is flying"
  end
  def make_noise
    puts 'Chirp.'
  end
  def swim
    puts "The #{@kind} is swimming"
  end
end

class Crow < Bird
  def initialize
    @kind = 'Crow'
  end
  def fly
     puts 'The crow is flying.'
  end
  def make_noise
    puts 'Kaw kaw.'
  end
end

class Penguin < Bird
  def initialize
    @kind = 'Penguin'
  end
end

def sound_off birds
  birds.each do |bird|
    bird.make_noise
  end
end
def fly_away birds
  birds.each do |bird|
    bird.fly
  end
end
def go_swim birds
  birds.each do |bird|
    bird.swim
  end
end

crow = Crow.new
penguin = Penguin.new
birds = [crow,penguin]

sound_off birds
fly_away birds
go_swim birds
