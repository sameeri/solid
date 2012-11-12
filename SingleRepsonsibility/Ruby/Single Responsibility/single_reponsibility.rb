
module ModemConnection
  def dial number
    #some code that establishes a connection
  end

  def hang_up
    #some code that hangs up connection
  end
end

module ModemCommunication
  def send datum
    #some code that sends some datum
  end

  def receive
    #some code that receives datum
  end
end


class Modem
  include ModemCommunication
  include ModemConnection

  ManufacturerName = ""
  BuildNum = ""
  Color = ""

end