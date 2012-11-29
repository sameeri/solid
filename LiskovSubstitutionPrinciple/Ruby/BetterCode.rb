

module Fly
  def fly
    raise 'NotImplemented'
  end
end
module MakeNoise
  def make_noise
    raise 'NotImplemented'
  end
end
module Swim
  def swim
    raise 'NotImplemented'
  end
end

class Bird
  attr_accessor :kind
end

class Crow < Bird
  include Fly
  include MakeNoise
  def initialize
    @kind = 'Crow'
  end
  def fly
    p "The #@kind is flying"
  end

  def make_noise
    p 'Kaw kaw.'
  end
end

class Penguin < Bird
  include MakeNoise
  include Swim
  def initialize
    @kind = 'Penguin'
  end
  def make_noise
    p 'Sqwuak!'
  end
  def swim
    p "The #@kind is swimming"
  end
end

class Duck < Bird
  include Fly
  include Swim
  include MakeNoise
  def initialize
    @kind = 'Duck'
  end
  def make_noise
    p 'Quack!'
  end
  def swim
    p "The #@kind is swimming"
  end
  def fly
    p "The #@kind is flying"
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
duck = Duck.new

noisy_birds = [crow,penguin,duck]
flying_birds = [crow,duck]
swimming_birds = [penguin,duck]


sound_off noisy_birds
fly_away flying_birds
go_swim swimming_birds
