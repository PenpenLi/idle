# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: mail_server_db.proto

import sys
_b=sys.version_info[0]<3 and (lambda x:x) or (lambda x:x.encode('latin1'))
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()




DESCRIPTOR = _descriptor.FileDescriptor(
  name='mail_server_db.proto',
  package='dhc',
  syntax='proto2',
  serialized_options=None,
  serialized_pb=_b('\n\x14mail_server_db.proto\x12\x03\x64hc\"\xe4\x01\n\rmail_server_t\x12\x0c\n\x04guid\x18\x01 \x01(\x04\x12\x16\n\x0ereceiver_guids\x18\x02 \x03(\x04\x12\x14\n\x0c\x64\x65lete_guids\x18\x03 \x03(\x04\x12\x13\n\x0bsender_date\x18\x04 \x01(\x04\x12\r\n\x05title\x18\x05 \x01(\t\x12\x0c\n\x04text\x18\x06 \x01(\t\x12\x13\n\x0bsender_name\x18\x07 \x01(\t\x12\x0c\n\x04type\x18\x08 \x03(\x05\x12\x0e\n\x06value1\x18\t \x03(\x05\x12\x0e\n\x06value2\x18\n \x03(\x05\x12\x0e\n\x06value3\x18\x0b \x03(\x05\x12\x12\n\ncreat_time\x18\x0c \x01(\x04')
)




_MAIL_SERVER_T = _descriptor.Descriptor(
  name='mail_server_t',
  full_name='dhc.mail_server_t',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='guid', full_name='dhc.mail_server_t.guid', index=0,
      number=1, type=4, cpp_type=4, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='receiver_guids', full_name='dhc.mail_server_t.receiver_guids', index=1,
      number=2, type=4, cpp_type=4, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='delete_guids', full_name='dhc.mail_server_t.delete_guids', index=2,
      number=3, type=4, cpp_type=4, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='sender_date', full_name='dhc.mail_server_t.sender_date', index=3,
      number=4, type=4, cpp_type=4, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='title', full_name='dhc.mail_server_t.title', index=4,
      number=5, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='text', full_name='dhc.mail_server_t.text', index=5,
      number=6, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='sender_name', full_name='dhc.mail_server_t.sender_name', index=6,
      number=7, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='type', full_name='dhc.mail_server_t.type', index=7,
      number=8, type=5, cpp_type=1, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='value1', full_name='dhc.mail_server_t.value1', index=8,
      number=9, type=5, cpp_type=1, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='value2', full_name='dhc.mail_server_t.value2', index=9,
      number=10, type=5, cpp_type=1, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='value3', full_name='dhc.mail_server_t.value3', index=10,
      number=11, type=5, cpp_type=1, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='creat_time', full_name='dhc.mail_server_t.creat_time', index=11,
      number=12, type=4, cpp_type=4, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=30,
  serialized_end=258,
)

DESCRIPTOR.message_types_by_name['mail_server_t'] = _MAIL_SERVER_T
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

mail_server_t = _reflection.GeneratedProtocolMessageType('mail_server_t', (_message.Message,), dict(
  DESCRIPTOR = _MAIL_SERVER_T,
  __module__ = 'mail_server_db_pb2'
  # @@protoc_insertion_point(class_scope:dhc.mail_server_t)
  ))
_sym_db.RegisterMessage(mail_server_t)


# @@protoc_insertion_point(module_scope)

mail_server_t_tmp = mail_server_t

from pgame.utils import proto_utils
class mail_server_t_db(proto_utils.object_t_db):
   def __init__(self):
      proto_utils.object_t_db.__init__(self, mail_server_t_tmp)
      self.children = [
         ]

proto_utils.make_db_proto(mail_server_t_db, mail_server_t_tmp)

mail_server_t = mail_server_t_db
